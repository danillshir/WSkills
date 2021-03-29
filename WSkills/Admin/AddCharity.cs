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
    public partial class AddCharity : Form
    {
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        string imageLocation = "";
        string imageName = "";
        public AddCharity()
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCharity.ActiveForm.Hide();
            EditCharity editCharity = new EditCharity();
            editCharity.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT * from Charity where CharityName = '{nameTextBox.Text}' ", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    command = new SqlCommand($"insert into Charity(CharityName,  CharityDescription, CharityLogo) values ('{nameTextBox.Text}','{descriptionTextBox.Text}','{imageName}')", connectionSql);
                    command.ExecuteNonQuery();
                }
                else
                {
                    if (imageName == "")
                    {
                        
                    }
                    command = new SqlCommand($"update Charity set CharityName = '{nameTextBox.Text}', CharityDescription = '{descriptionTextBox.Text}', CharityLogo = '{imageName}' where CharityId = {Convert.ToInt32(dataSet.Tables[0].Rows[0][0])} ", connectionSql);
                    command.ExecuteNonQuery();
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            AddCharity.ActiveForm.Hide();
            EditCharity editCharity = new EditCharity();
            editCharity.Show();
        }
        public void loadChairity() //Загрузка организаций
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

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

        private void photoButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Файлы JPG (*.jpg)|*.jpg|Файлы PNG (*.png)|*.png|Все файлы (*.*)|*.*";
                dialog.Title = "Выбрать фотографию";
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    imageLocation = dialog.FileName.ToString();
                    logoPictureBox.ImageLocation = imageLocation;
                    photoTextBox.Text = dialog.FileName;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AddCharity_Load(object sender, EventArgs e)
        {
            loadChairity();
        }
    }
}
