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

namespace WSkills
{
    public partial class RunnerSponsor : Form
    {
        int money;
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";
        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter dataAdapter;

        DataTable table;
        public RunnerSponsor()
        {
            InitializeComponent();
            timer1.Start();
            connectionSql = new SqlConnection(connection);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string check = checkToAdd();
            if (check == "OK")
            {
                try
                {

                    connectionSql.Open();

                    command = new SqlCommand($"insert into [Sponsorship] (SponsorName, RegistrationId, Amount) values ('{textBox1.Text.ToUpper()}', {comboBox1.SelectedValue}, {moneyTextBox.Text}.00)", connectionSql);
                    command.ExecuteNonQuery();

                    RunnerSponsor.ActiveForm.Hide();
                    Runer.SponsorConfirmation form = new Runer.SponsorConfirmation();
                    form.Show();
                }
                catch
                {
                    MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
                MessageBox.Show(check);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            money = Convert.ToInt32(moneyTextBox.Text);
            if (money >= 0)
            {
                money = money + 10;
                moneyTextBox.Text = Convert.ToString(money);
                label14.Text = "$" + Convert.ToString(money);
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            money = Convert.ToInt32(moneyTextBox.Text);
            if (money > 9)
            {
                money = money - 10;
                moneyTextBox.Text = Convert.ToString(money);
                label14.Text = "$" + Convert.ToString(money);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label14.Text = "$" + moneyTextBox.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                DataRow dataRow = table.Rows[Convert.ToInt32(comboBox1.SelectedIndex)];
                label12.Text = dataRow[2].ToString();
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ваше имя")
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Владелец карты")
            {
                textBox2.Text = "";
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "1234 1234 1234 1234")
            {
                textBox4.Text = "";
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "00")
            {
                textBox6.Text = "";
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "0000")
            {
                textBox3.Text = "";
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "000")
            {
                textBox5.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
        private string checkToAdd()
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                return "Не все поля заполнены";
            if (Convert.ToInt32(moneyTextBox.Text) == 0)
                return "Пожертвование не может быть равно 0";
            if (Convert.ToInt32(textBox6.Text) == 0 || Convert.ToInt32(textBox6.Text) > 12 || Convert.ToInt32(textBox6.Text) < DateTime.Today.Month)
                return "Некорректный ввод месяца в сроке действия";
            if (Convert.ToInt32(textBox3.Text) < 2021)
                return "Некорректный ввод года в сроке действия";

            return "OK";

        }

        private void RunnerSponsor_Load(object sender, EventArgs e)
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Registration.RegistrationId, dbo.[User].FirstName + ' ' + dbo.[User].LastName + ' - ' + CONVERT(varchar, dbo.Registration.RunnerId) + ' (' + dbo.Country.CountryName + ')' AS Runner, dbo.Charity.CharityName, dbo.Charity.CharityLogo, dbo.Charity.CharityDescription FROM dbo.Charity INNER JOIN dbo.Registration ON dbo.Charity.CharityId = dbo.Registration.CharityId INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                table = dataSet.Tables[0];
                comboBox1.DataSource = table;
                comboBox1.DisplayMember = "Runner";
                comboBox1.ValueMember = "RegistrationId";

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
    }
}
