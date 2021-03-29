using System;
using System.Windows.Forms;

namespace WSkills.Runer
{
    public partial class SponsorConfirmation : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        public SponsorConfirmation()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }
    }
}
