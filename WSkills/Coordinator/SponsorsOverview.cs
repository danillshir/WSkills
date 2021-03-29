using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSkills.Coordinator
{
    public partial class SponsorsOverview : Form
    {
        public string email;
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        public SponsorsOverview(string email)
        {
            this.email = email;
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            CoordinatorMenu coordinatorMenu = new CoordinatorMenu();
            coordinatorMenu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }
    }
}
