﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WSkills.Admin
{
    public partial class AddVolunteers : Form
    {
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";
        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter DataAdapter;
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        string fileLocation = "";
        public AddVolunteers()
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddVolunteers.ActiveForm.Hide();
            MenuAdm menuAdm = new MenuAdm();
            menuAdm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddVolunteers.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string[] line = File.ReadAllLines(fileLocation);
                connectionSql.Open();
                DataSet dataset = new DataSet();
                dataset.Tables.Add();
                dataset.Tables[0].Columns.Add("Номер поля", typeof(int));
                dataset.Tables[0].Columns.Add("Изменение", typeof(string));
                for (int i = 1; i < line.Length; i++)
                {
                    string[] stringSplit = line[i].Split(',');
                    DataAdapter = new SqlDataAdapter($"SELECT {line[0]} from Volunteer where VolunteerId = '{stringSplit[0]}' ", connectionSql);
                    DataSet dataSetFor = new DataSet();
                    DataAdapter.Fill(dataSetFor);
                    csvDataGrid.DataSource = dataSetFor.Tables[0];
                    if (dataSetFor.Tables[0].Rows.Count > 0)
                    {
                        command = new SqlCommand($"update dbo.[Volunteer] set FirstName = '{stringSplit[1]}', LastName = '{stringSplit[2]}',CountryCode = '{stringSplit[3]}',Gender = '{stringSplit[4]}' where VolunteerId = '{stringSplit[0]}' ", connectionSql);
                        dataset.Tables[0].Rows.Add(stringSplit[0], "Update");
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        command = new SqlCommand($"insert into Volunteer(FirstName,  LastName, CountryCode,Gender) values ('{stringSplit[1]}','{stringSplit[2]}','{stringSplit[3]}','{stringSplit[4]}')", connectionSql);
                        dataset.Tables[0].Rows.Add(stringSplit[0], "Insert");
                        command.ExecuteNonQuery();
                    }
                }

                csvDataGrid.DataSource = dataset.Tables[0];
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

        private void fileButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Файлы CSV (*.csv)|*.csv";
                dialog.Title = "Выбрать файла";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileLocation = dialog.FileName;
                    fileTextBox.Text = fileLocation;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
