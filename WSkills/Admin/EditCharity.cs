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
    public partial class EditCharity : Form
    {
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        public EditCharity()
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
            EditCharity.ActiveForm.Hide();
            MenuAdm menuAdm = new MenuAdm();
            menuAdm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditCharity.ActiveForm.Hide();
            AddCharity addCharity = new AddCharity();
            addCharity.Show();

        }
        public void charity() //Вызгурзка организаций из базы данных и настройка карточки
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                Admin.SponsorOrganizationUserControl[] Control = new SponsorOrganizationUserControl[dataSet.Tables[0].Rows.Count];
                DataTable table = new DataTable();
                int i = 0; while (i < dataSet.Tables[0].Rows.Count)
                {

                    Control[i] = new SponsorOrganizationUserControl();
                    Control[i].Title = dataSet.Tables[0].Rows[i][1].ToString();
                    Control[i].Message = dataSet.Tables[0].Rows[i][2].ToString();
                    Control[i].Check = true;
                    if (organizationLayoutPanel.Controls.Count < 0)
                    {
                        organizationLayoutPanel.Controls.Clear();
                    }
                    else
                    {
                        organizationLayoutPanel.Controls.Add(Control[i]);
                    }
                    i++;
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

        private void EditCharity_Load(object sender, EventArgs e)
        {
            charity();
        }
    }
}
