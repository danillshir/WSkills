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

namespace WSkills.Admin
{
    public partial class Volunteers : Form
    {
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        public Volunteers()
        {

            InitializeComponent();
            timer1.Start();
            connectionSql = new SqlConnection(connection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin.Volunteers.ActiveForm.Hide();
            MenuAdm menuAdm = new MenuAdm();
            menuAdm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Admin.Volunteers.ActiveForm.Hide();
            AddVolunteers addVolunteers = new AddVolunteers();
            addVolunteers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin.Volunteers.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        public void loadVolunters() 
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Volunteer.VolunteerId, dbo.Country.CountryCode, dbo.Volunteer.LastName AS Фамилия, dbo.Volunteer.FirstName AS Имя, dbo.Country.CountryName AS Страна, dbo.Gender.Gender AS Пол FROM    dbo.Country INNER JOIN dbo.Volunteer ON dbo.Country.CountryCode = dbo.Volunteer.CountryCode INNER JOIN dbo.Gender ON dbo.Volunteer.Gender = dbo.Gender.Gender", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                volunterDataGrid.DataSource = dataSet.Tables[0];
                volunterDataGrid.Columns[0].Visible = false;
                volunterDataGrid.Columns[1].Visible = false;
                volunterNumberLabel.Text = dataSet.Tables[0].Rows.Count.ToString();

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

        private void Volunteers_Load(object sender, EventArgs e)
        {
            loadVolunters();
        }
    }
}
