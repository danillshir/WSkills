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
    public struct Users
    {
        public string login;
        public string password;
        public string type;
    }

    public partial class Login : Form
    {
        public static Users users = new Users();
        public static string email;
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        TimeSpan d = new TimeSpan();

        DateTime date = new DateTime(2021, 3, 8);
        DataTable table;
        public Login()
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

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите вашу почту")
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите ваш пароль")
            {
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT [Email], [Password], [RoleId] FROM [dbo].[User] WHERE [Email] = '{textBox1.Text}' and [Password] = '{textBox2.Text}'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                table = dataSet.Tables[0];

                if (table.Rows.Count != 0)
                {
                    email = textBox1.Text;
                    DataRow dataRow = table.Rows[0];
                    if (dataRow[2].ToString() == "A")
                    {
                        Login.ActiveForm.Hide();
                        Admin.MenuAdm form = new Admin.MenuAdm();
                        form.Show();
                    }
                    if (dataRow[2].ToString() == "C")
                    {
                        Login.ActiveForm.Hide();
                        Coordinator.CoordinatorMenu form = new Coordinator.CoordinatorMenu();
                        form.Show();
                    }
                    if (dataRow[2].ToString() == "R")
                    {
                        Login.ActiveForm.Hide();
                        Runer.RunnerMenu form = new Runer.RunnerMenu();
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }

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

        private void button4_Click(object sender, EventArgs e)
        {
            Login.ActiveForm.Hide();
            Admin.MenuAdm form = new Admin.MenuAdm();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login.ActiveForm.Hide();
            Coordinator.CoordinatorMenu form = new Coordinator.CoordinatorMenu();
            form.Show();
        }
    }
}
