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
    public partial class Admission : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlCommand command;
        public Admission()
        {
            InitializeComponent();
            timer1.Start();
            connectionSql = new SqlConnection(connection);
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                connectionSql.Open();
                if (int.TryParse(idTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(idTextBox.Text)} where InventoryId = 1", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(rfidTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(rfidTextBox.Text)} where InventoryId = 2", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(baseballTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(baseballTextBox.Text)} where InventoryId = 3", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(waterTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(waterTextBox.Text)} where InventoryId = 4", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(tshirtTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(tshirtTextBox.Text)} where InventoryId = 5", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(souvenirTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(souvenirTextBox.Text)} where InventoryId = 6", connectionSql);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Данные успешно обновлены!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Admission.ActiveForm.Hide();
            Admin.Invent form = new Invent();
            form.Show();
        }
    }
}
