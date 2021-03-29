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
    public partial class MyCharity : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public MyCharity()
        {
            InitializeComponent();
            timer1.Start();
            connectionSql = new SqlConnection(connection);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyCharity.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void MyCharity_Load(object sender, EventArgs e)
        {
            loadCharity();
            loadSponsors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCharity.ActiveForm.Hide();
            RunnerMenu runnerMenu = new RunnerMenu();
            runnerMenu.Show();
        }
        private void loadCharity()
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("select [CharityName], [CharityDescription], [CharityLogo] from Registration " +
                    "inner join Charity on[Registration].[CharityId] = [Charity].[CharityId] " +
                    $"where RunnerId = (select RunnerId from Runner where Email = '{Login.email}')", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                infoLabel.Text = (string)dataSet.Tables[0].Rows[0][0];
                descriptionTextBox.Text = (string)dataSet.Tables[0].Rows[0][1];
          

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

        private void loadSponsors() 
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT [SponsorName], [Amount] from [Sponsorship] where RegistrationId = (select RegistrationId from Registration where RunnerId = (select RunnerId from Runner where Email = '{Login.email}'))", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                int total = 0;
                sponsorMoneyUserControl[] Control = new sponsorMoneyUserControl[dataSet.Tables[0].Rows.Count];
                DataTable Table = new DataTable();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Control[i] = new sponsorMoneyUserControl();
                    Control[i].NameLabel = dataSet.Tables[0].Rows[i][0].ToString();
                    Control[i].Amount = '$' + dataSet.Tables[0].Rows[i][1].ToString();
                    total += Convert.ToInt32(dataSet.Tables[0].Rows[i][1]);
                    if (flowLayoutPanel.Controls.Count < 0)
                    {
                        flowLayoutPanel.Controls.Clear();
                    }
                    else
                    {
                        flowLayoutPanel.Controls.Add(Control[i]);
                    }
                }
                totalLabel.Text = "Всего $" + total.ToString();

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
