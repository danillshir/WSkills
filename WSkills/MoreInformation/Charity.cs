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

namespace WSkills.MoreInformation
{
    public partial class Charity : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        string connection = @"Data Source=D-PK\SQLEXPRESS;Initial Catalog=Marathon1;Integrated Security=True";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public Charity()
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
            Close();
            Information information = new Information();
            information.Show();
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Charity_Load(object sender, EventArgs e)
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                Admin.SponsorOrganizationUserControl[] control = new Admin.SponsorOrganizationUserControl[dataSet.Tables[0].Rows.Count];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    control[i] = new Admin.SponsorOrganizationUserControl();
                    control[i].Title = dataSet.Tables[0].Rows[i][1].ToString();
                    control[i].Message = dataSet.Tables[0].Rows[i][2].ToString();
                    control[i].Check = false;
                    flowLayoutPanel.Controls.Add(control[i]);
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
    }
}
