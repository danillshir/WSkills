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
using System.Text.RegularExpressions;
using System.IO;

namespace WSkills.Runer
{
    public partial class RunnerRegistratsia : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter dataAdapter;

        string imageLocation = "";

        public RunnerRegistratsia()
        {
            InitializeComponent();
            timer1.Start();
            connectionSql = new SqlConnection(connection);
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            loadGender();
            loadCountries();
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunnerRegister runnerRegister = new RunnerRegister();
            runnerRegister.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string result = checkToAdd();
            if (result == "ОК")
            {
                try
                {
                    DateTime dateOfBirth = Convert.ToDateTime(birthDateTimePicker.Value);
                    connectionSql.Open();

                    command = new SqlCommand($"insert into [dbo].[User] (Email, Password, FirstName, LastName, RoleId, Picture) values('{emailTextBox.Text}', '{passwordTextBox.Text}','{nameTextBox.Text.ToUpper()}','{lastNameTextBox.Text.ToUpper()}','R', '{photoTextBox.Text.ToUpper()}')", connectionSql);
                    command.ExecuteNonQuery();
                    connectionSql.Close();



                    connectionSql.Open();
                    command = new SqlCommand($"insert into [dbo].[Runner] (Email, Gender, DateOfBirth, CountryCode) values('{emailTextBox.Text}','{genderComboBox.Text}', '{birthDateTimePicker.Value}',(select [CountryCode] from [Country] where CountryName = '{countryComboBox.Text}'))", connectionSql);

                    command.ExecuteNonQuery();

                    Login.email = emailTextBox.Text;
                    RunnerRegistratsia.ActiveForm.Hide();
                    RunnerMaraphonRegister form = new RunnerMaraphonRegister();
                    form.Show();

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
                MessageBox.Show(result);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            RunnerRegistratsia.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void photoButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Файлы JPG (*.jpg)|*.jpg|Файлы PNG (*.png)|*.png";
                dialog.Title = "Выбрать фотографию";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    photoPictureBox.ImageLocation = imageLocation;
                    photoTextBox.Text = dialog.FileName;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void loadGender() //загрузка полов и выгрузка их в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from Gender", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                genderComboBox.DataSource = dataSet.Tables[0];
                genderComboBox.DisplayMember = "Gender";
                genderComboBox.ValueMember = "Gender";

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
        private void loadCountries() //загрузка стран и выгрузка их в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT [CountryName] from Country", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                countryComboBox.DataSource = dataSet.Tables[0];
                countryComboBox.DisplayMember = "CountryName";
                countryComboBox.ValueMember = "CountryName";

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
        private string checkToAdd() //все проверки на текст, пароль и имейл
        {
            if (emailTextBox.Text == "" || passwordTextBox.Text == "" || passwordAgainTextBox.Text == "" || nameTextBox.Text == "" || lastNameTextBox.Text == "" || genderComboBox.Text == "" || photoTextBox.Text == "" || countryComboBox.Text == "")
                return "Не все поля заполнены";

            try { var mail = new System.Net.Mail.MailAddress(emailTextBox.Text); }
            catch { return "Некорректный e-mail адрес"; }

            if (passwordTextBox.Text.Length < 6 || !Regex.IsMatch(passwordTextBox.Text, @"[0-9]") || !Regex.IsMatch(passwordTextBox.Text, @"[A-Z]") || !Regex.IsMatch(passwordTextBox.Text, @"[!@#$%^]"))
                return "Неверно введен пароль. Пароль должен имень минимум 6 символов, 1 прописную букву, 1 цифру и один из этих символов: !@#$%^";

            if (passwordTextBox.Text != passwordAgainTextBox.Text)
                return "Пароли не совпадают";

            DateTime today = DateTime.Today;
            if (today.Subtract(birthDateTimePicker.Value).Days / 365 < 10)
                return "Вам еще не исполнилось 10 лет";

            if (!nameTextBox.Text.All(c => char.IsLetter(c)))
                return "В имени есть лишние символы";

            if (!lastNameTextBox.Text.All(c => char.IsLetter(c)))
                return "В фамилии есть лишние символы";

            return "ОК";
        }

        private void RunnerRegistratsia_Load(object sender, EventArgs e)
        {
            birthDateTimePicker.Format = DateTimePickerFormat.Custom;
            birthDateTimePicker.CustomFormat = "yyyy-MM-dd";
        }

        private void birthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
