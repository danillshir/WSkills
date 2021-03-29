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
    public partial class RunnerResults : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        int minAge, maxAge = 0;
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        DataTable table;
        public RunnerResults()
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
            RunnerResults.ActiveForm.Hide();
            RunnerMenu runnerMenu = new RunnerMenu();
            runnerMenu.Show();
        }

        private void RunnerResults_Load(object sender, EventArgs e)
        {
            try
            {
                takeAgesAndGender();
                connectionSql.Open();

                string query = "SELECT [RegistrationId], [MarathonName] as 'Марафон', [EventTypeName] as 'Дистанция', CONVERT(nvarchar, CONVERT(datetime, [RaceTime]/100000.0), 8)  AS 'Время', " +
                    "(select[PlaceId] from[Place]([MarathonName], [EventTypeName]) where[RegId] = [RegistrationId]) as 'Общее место'," +
                    $"(select[PlaceId] from[PlaceYear]([MarathonName], [EventTypeName], {minAge}, {maxAge}) where[RegId] = [RegistrationId]) as 'Место по категории'" +
                    "FROM[RegistrationEvent] " +
                    "inner join[Event] on[RegistrationEvent].[EventId] = [Event].[EventId] " +
                    "inner join[Marathon] on Event.[MarathonId] = [Marathon].[MarathonId] " +
                    "inner join[EventType] on Event.EventTypeId = EventType.EventTypeId " +
                    "where[RegistrationId] = (select RegistrationId from Registration where RunnerId = " +
                    $"(select RunnerId from Runner where Email = '{Login.email}'))";

                dataAdapter = new SqlDataAdapter(query, connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                table = dataSet.Tables[0];

                resultDataGrid.DataSource = table;
                resultDataGrid.Columns[0].Visible = false;
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

        private void showButton_Click(object sender, EventArgs e)
        {
            RunnerResults.ActiveForm.Hide();
            MoreInformation.PreviousRaceResults previous = new MoreInformation.PreviousRaceResults();
            previous.Show();
        }
        private void takeAgesAndGender()//Выставляем диапазон возраста в зависимости от возраста нашего пользователя
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter($"select YEAR(GETDATE())-YEAR([DateOfBirth]), [Gender] from [Runner] where  Email = '{Login.email}'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                int age = (int)dataSet.Tables[0].Rows[0][0];
                genderLoadLabel.Text = (string)dataSet.Tables[0].Rows[0][1];

                if (age < 18)
                {
                    minAge = 0;
                    maxAge = 17;
                }
                if (age >= 18 && age <= 29)
                {
                    minAge = 18;
                    maxAge = 29;
                }
                if (age >= 30 && age <= 39)
                {
                    minAge = 30;
                    maxAge = 39;
                }
                if (age >= 40 && age <= 55)
                {
                    minAge = 40;
                    maxAge = 55;
                }
                if (age >= 56 && age <= 70)
                {
                    minAge = 56;
                    maxAge = 70;
                }
                if (age > 70)
                {
                    minAge = 71;
                    maxAge = 120;
                }
                ageLoadLabel.Text = $"{minAge}-{maxAge}";
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
