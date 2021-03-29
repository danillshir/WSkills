using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSkills.Admin
{

    public partial class MenuAdm : Form
    {
        public string email;
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        public MenuAdm()
        {
            
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuAdm.ActiveForm.Hide();
            Invent invent = new Invent();
            invent.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuAdm.ActiveForm.Hide();
            EditCharity editCharity = new EditCharity();
            editCharity.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuAdm.ActiveForm.Hide();
            Volunteers volunteers = new Volunteers();
            volunteers.Show();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}
