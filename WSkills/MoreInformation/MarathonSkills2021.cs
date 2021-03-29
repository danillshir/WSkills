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
    public partial class MarathonSkills2021 : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        public MarathonSkills2021()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MarathonSkills2021.ActiveForm.Hide();
            InformationMap informationMap = new InformationMap();
            informationMap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form Information = new MoreInformation.Information();
            Information.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }
    }
}
