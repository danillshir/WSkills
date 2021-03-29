using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WSkills.Runer
{
    public partial class RunnerMaraphonRegister : Form
    {
        
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        int amount = 0;
        int amountKit = 0;
        char raceKit = 'A';
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        DataTable table;
        public RunnerMaraphonRegister()
        {
            InitializeComponent();
            timer1.Start();
            connectionSql = new SqlConnection(connection);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                raceKit = 'A';
                amountKit = 0;
                label10.Text = (amount + amountKit).ToString() + '$';
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                raceKit = 'A';
                amountKit = 20;
                label10.Text = (amount + amountKit).ToString() + '$';
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                raceKit = 'A';
                amountKit = 45;
                label10.Text = (amount + amountKit).ToString() + '$';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunnerMaraphonRegister.ActiveForm.Hide();
            RunnerMenu runnerMenu = new RunnerMenu();
            runnerMenu.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                amount += 145;
            else
                amount -= 145;
            label10.Text = (amount + amountKit).ToString() + '$';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                amount += 75;
            else
                amount -= 75;
            label10.Text = (amount + amountKit).ToString() + '$';
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                amount += 20;
            else
                amount -= 20;
            label10.Text = (amount + amountKit).ToString() + '$';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked || checkBox2.Checked || checkBox3.Checked) && Convert.ToInt32(textBox1.Text) >= amount)
            {
                try
                {
                    connectionSql.Open();

                    command = new SqlCommand($"insert into [Registration] (RunnerId, RegistrationDateTime, RaceKitOptionId, RegistrationStatusId, Cost, CharityId, SponsorshipTarget) values ((select [RunnerId] from [Runner] where [Email] = '{Login.email}'), GETDATE(), '{raceKit}', 1, {amountKit}, {comboBox1.SelectedValue}, {textBox1.Text})", connectionSql);
                    command.ExecuteNonQuery();
                    Random random = new Random();
                    if (checkBox1.Checked)
                    {
                        command = new SqlCommand($"insert into RegistrationEvent (RegistrationId, EventId, BibNumber) values ((select RegistrationId from Registration where [RunnerId] = (select [RunnerId] from [Runner] where [Email] = '{Login.email}')),'{eventSelect("FM")}',{random.Next(1727)})", connectionSql);
                        command.ExecuteNonQuery();
                    }
                    if (checkBox2.Checked)
                    {
                        command = new SqlCommand($"insert into RegistrationEvent (RegistrationId, EventId, BibNumber) values ((select RegistrationId from Registration where [RunnerId] = (select [RunnerId] from [Runner] where [Email] = '{Login.email}')),'{eventSelect("HM")}',{random.Next(1727)})", connectionSql);
                        command.ExecuteNonQuery();

                    }
                    if (checkBox3.Checked)
                    {
                        command = new SqlCommand($"insert into RegistrationEvent (RegistrationId, EventId, BibNumber) values ((select RegistrationId from Registration where [RunnerId] = (select [RunnerId] from [Runner] where [Email] = '{Login.email}')),'{eventSelect("FR")}',{random.Next(1727)})", connectionSql);
                        command.ExecuteNonQuery();
                    }

                    RunnerMaraphonRegister.ActiveForm.Hide();
                    Runer.RunnerThanks ty = new RunnerThanks();
                    ty.Show();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);

                }
                finally
                {
                    connectionSql.Close();
                }
            }
            else
            {
                MessageBox.Show("Выберите вид марафона или проверьте сумму взноса");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }
        private string eventSelect(string marathonType) //Выбор марафона, к которому привяжется пользователь
        {
            try
            {
                dataAdapter = new SqlDataAdapter($"SELECT [EventId] FROM [Marathon1].[dbo].[Event] where EventTypeId = '{marathonType}'", connectionSql);
                DataSet dataSource = new DataSet();

                dataAdapter.Fill(dataSource);
                List<string> allEvents = new List<string>();
                for (int i = 0; i < dataSource.Tables[0].Rows.Count; i++)
                {
                    allEvents.Add((string)dataSource.Tables[0].Rows[i][0]);
                }
                Random random = new Random();
                return allEvents[random.Next(allEvents.Count - 1)];

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return "";
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void RunnerMaraphonRegister_Load(object sender, EventArgs e)
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                table = dataSet.Tables[0];

                comboBox1.DataSource = dataSet.Tables[0];
                comboBox1.DisplayMember = "CharityName";
                comboBox1.ValueMember = "CharityId";

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connectionSql.Close();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
