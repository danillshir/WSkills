using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSkills.MoreInformation
{
    public partial class Information : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        public Information()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Information.ActiveForm.Hide();
            MoreInformation.Charity charity = new Charity();
            charity.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Information.ActiveForm.Hide();
            MoreInformation.HowLongIsAMarathon howLongIsAMarathon = new HowLongIsAMarathon();
            howLongIsAMarathon.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Information.ActiveForm.Hide();
            MarathonSkills2021 marathonSkills2021 = new MarathonSkills2021();
            marathonSkills2021.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Information.ActiveForm.Hide();
            PreviousRaceResults previousRaceResults = new PreviousRaceResults();
            previousRaceResults.Show();
        }
    }
}
