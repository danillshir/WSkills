using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Globalization;


namespace WSkills.Runer
{
    public partial class RunnerEdit : Form
    {

        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataRow row;
        string imageLocation = "";
        public RunnerEdit()
        {
            InitializeComponent();
            timer1.Start();
            connectionSql = new SqlConnection(connection);
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunnerMenu runnerMenu = new RunnerMenu();
            runnerMenu.Show();
            Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string result = checkToAdd();
            if (result == "ОК")
            {
                try
                {
                    
                    
                    connectionSql.Open();

                    string name = nameTextBox.Text;
                    string lastName = lastNameTextBox.Text;
                    string gender = genderComboBox.Text;
                    string country = countryComboBox.SelectedValue.ToString();
                    string photoText = photoTextBox.Text;
                    DateTime dateOfBirth = Convert.ToDateTime(birthDateTimePicker.Value);
                    string password = (string)row[7];
                    if (passwordTextBox.Text != "" || passwordAgainTextBox.Text != "")
                    {
                        string resultPassword = changePassword();
                        if (resultPassword == "ОК")
                        {
                            password = passwordTextBox.Text;
                        }
                        else
                        {
                            MessageBox.Show(resultPassword);
                        }
                    }


                    command = new SqlCommand($"update[dbo].[User] set Password = '{password}', FirstName = '{name}', LastName = '{lastName}', Picture = '{photoText}' where Email = '{emailUserLabel.Text}'", connectionSql);
                    command.ExecuteNonQuery();
                    connectionSql.Close();

                    connectionSql.Open();
                    command = new SqlCommand($"update[dbo].[Runner] set Gender = '{gender}', CountryCode = '{country}', DateOfBirth = '{birthDateTimePicker.Value}' where Email = '{emailUserLabel.Text}'", connectionSql);
                    command.ExecuteNonQuery();

                    RunnerEdit.ActiveForm.Hide();
                    RunnerMenu form = new RunnerMenu();
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            RunnerMenu runnerMenu = new RunnerMenu();
            runnerMenu.Show();
            Close();
        }

        private void RunnerEdit_Load(object sender, EventArgs e)
        {
            loadGender();
            loadCountries();
            loadData();
        }
        private void loadGender() // Загрузка полов и выгрузка в список
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

        private void loadCountries() // Загрузка стран и выгразка в список 
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT [CountryCode], [CountryName] from Country", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                countryComboBox.DataSource = dataSet.Tables[0];
                countryComboBox.DisplayMember = "CountryName";
                countryComboBox.ValueMember = "CountryCode";

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


        private string checkToAdd() //Все проверки для текста
        {
            DateTime today = DateTime.Today;
            if (today.Subtract(birthDateTimePicker.Value).Days / 365 < 10)
                return "Вам еще не исполнилось 10 лет";

            if (!nameTextBox.Text.All(c => char.IsLetter(c)))
                return "В имени есть лишние символы";

            if (!lastNameTextBox.Text.All(c => char.IsLetter(c)))
                return "В фамилии есть лишние символы";

            return "ОК";
        }

        private string changePassword() //Все проверки для паролей
        {
            if (passwordTextBox.Text.Length < 6 || !Regex.IsMatch(passwordTextBox.Text, @"[0-9]") || !Regex.IsMatch(passwordTextBox.Text, @"[A-Z]") || !Regex.IsMatch(passwordTextBox.Text, @"[!@#$%^]"))
                return "Неверно введен пароль. Пароль должен имень минимум 6 символов, 1 прописную букву, 1 цифру и один из этих символов: !@#$%^. Изменение пароля будет пропущено";

            if (passwordTextBox.Text != passwordAgainTextBox.Text)
                return "Пароли не совпадают. Изменение пароля будет пропущено";

            return "ОК";
        }

        private void loadData() //Загрузка информации о бегуне
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT dbo.Runner.Email, dbo.[User].FirstName, dbo.[User].LastName, dbo.Runner.Gender, dbo.Runner.DateOfBirth, dbo.Country.CountryName, dbo.[User].Picture, dbo.[User].Password FROM dbo.Runner INNER JOIN dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode WHERE (dbo.Runner.Email = '{Login.email}')", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                row = dataSet.Tables[0].Rows[0];
                emailUserLabel.Text = row[0].ToString();
                nameTextBox.Text = row[1].ToString();
                lastNameTextBox.Text = row[2].ToString();
                genderComboBox.Text = row[3].ToString();
                
                countryComboBox.Text = row[5].ToString();
                photoTextBox.Text = row[6].ToString();
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
