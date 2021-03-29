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
    public partial class Invent : Form
    {
        public string email;
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        DataTable table;
        public Invent()
        {
            InitializeComponent();
            timer1.Start();
            connectionSql = new SqlConnection(connection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdm menuAdm = new MenuAdm();
            menuAdm.Show();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            Report form = new Report();
            form.idLeftLabel.Text = idLeftLabel.Text;
            form.idNeedLabel.Text = idNeedLabel.Text;
            form.rfidLeftLabel.Text = rfidLeftLabel.Text;
            form.rfidNeedLabel.Text = rfidNeedLabel.Text;
            form.baseballLeftLabel.Text = baseballLeftLabel.Text;
            form.basebalNeedLabel.Text = basebalNeedLabel.Text;
            form.waterLeftLabel.Text = waterLeftLabel.Text;
            form.waterNeedLabel.Text = waterNeedLabel.Text;
            form.tshirtLeftLabel.Text = tshirtLeftLabel.Text;
            form.tshirtNeedLabel.Text = tshirtNeedLabel.Text;
            form.souvenirLeftLabel.Text = souvenirLeftLabel.Text;
            form.souvenirNeedLabel.Text = souvenirNeedLabel.Text;
            form.ShowDialog();
        }

        private void admissionButton_Click(object sender, EventArgs e)
        {
            Invent.ActiveForm.Hide();
            Admission form = new Admission();
            form.Show();
        }

        private void Invent_Load(object sender, EventArgs e)
        {
            loadRunners();
            
        }
        private void loadRunners() //Загрузка всех бегунов и их пакетов
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("select (select COUNT([RegistrationId])  from Registration) as 'All', (select COUNT([RegistrationId]) from Registration where RaceKitOptionId = 'A') as 'A', (select COUNT([RegistrationId])  from Registration where RaceKitOptionId = 'B') as 'B', (select COUNT([RegistrationId])  from Registration where RaceKitOptionId = 'C') as 'C'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                table = dataSet.Tables[0];

                totalNumberLabel.Text = table.Rows[0][0].ToString();

                typeANumberLabel.Text = table.Rows[0][1].ToString();
                idTypeALabel.Text = table.Rows[0][1].ToString();
                rfidTypeALabel.Text = table.Rows[0][1].ToString();

                typeBNumberLabel.Text = table.Rows[0][2].ToString();
                idTypeBLabel.Text = table.Rows[0][2].ToString();
                rfidTypeBLabel.Text = table.Rows[0][2].ToString();
                basebalTypeBLabel.Text = table.Rows[0][2].ToString();
                waterTypeBLabel.Text = table.Rows[0][2].ToString();

                typeCNumberLabel.Text = table.Rows[0][3].ToString();
                idTypeCLabel.Text = table.Rows[0][3].ToString();
                rfidTypeCLabel.Text = table.Rows[0][3].ToString();
                basebalTypeCLabel.Text = table.Rows[0][3].ToString();
                waterTypeCLabel.Text = table.Rows[0][3].ToString();
                tshirtTypeCLabel.Text = table.Rows[0][3].ToString();
                souvenirTypeCLabel.Text = table.Rows[0][3].ToString();

                idNeedLabel.Text = ((int)table.Rows[0][0]).ToString();
                rfidNeedLabel.Text = ((int)table.Rows[0][0]).ToString();
                basebalNeedLabel.Text = ((int)table.Rows[0][2] + (int)table.Rows[0][3]).ToString();
                waterNeedLabel.Text = ((int)table.Rows[0][2] + (int)table.Rows[0][3]).ToString();
                tshirtNeedLabel.Text = ((int)table.Rows[0][3]).ToString();
                souvenirNeedLabel.Text = ((int)table.Rows[0][3]).ToString();

                needNumberLabel.Text = ((int)table.Rows[0][0] + (int)table.Rows[0][0] + (int)table.Rows[0][2] + (int)table.Rows[0][3] + (int)table.Rows[0][2] + (int)table.Rows[0][3] + (int)table.Rows[0][3] + (int)table.Rows[0][3]).ToString();

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

        private void loadItems() //Загрузка всех предметов инвентаря
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("select [Amount] from Inventory", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                table = dataSet.Tables[0];

                idLeftLabel.Text = ((int)table.Rows[0][0] - Convert.ToInt32(idNeedLabel.Text)).ToString();
                rfidLeftLabel.Text = ((int)table.Rows[1][0] - Convert.ToInt32(rfidNeedLabel.Text)).ToString();
                baseballLeftLabel.Text = ((int)table.Rows[2][0] - Convert.ToInt32(basebalNeedLabel.Text)).ToString();
                waterLeftLabel.Text = ((int)table.Rows[3][0] - Convert.ToInt32(waterNeedLabel.Text)).ToString();
                tshirtLeftLabel.Text = ((int)table.Rows[4][0] - Convert.ToInt32(tshirtNeedLabel.Text)).ToString();
                souvenirLeftLabel.Text = ((int)table.Rows[5][0] - Convert.ToInt32(souvenirNeedLabel.Text)).ToString();

                leftNumberLabel.Text = ((int)table.Rows[0][0] + (int)table.Rows[1][0] + (int)table.Rows[2][0] + (int)table.Rows[3][0] + (int)table.Rows[4][0] + (int)table.Rows[5][0] - Convert.ToInt32(needNumberLabel.Text)).ToString();
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
