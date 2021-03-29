using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSkills.Runer
{
    public partial class RunnerMenu : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        public string email;
        public RunnerMenu()
        {
          
            InitializeComponent();
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form contacts = new Runer.Contacts();
            contacts.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunnerMenu.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RunnerMenu.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RunnerMenu.ActiveForm.Hide();
            Runer.RunnerMaraphonRegister rmr = new RunnerMaraphonRegister();
            rmr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RunnerMenu.ActiveForm.Hide();
            Runer.RunnerResults runnerResults = new RunnerResults();
            runnerResults.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RunnerMenu.ActiveForm.Hide();
            Runer.RunnerEdit runnerEdit = new RunnerEdit();
            runnerEdit.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RunnerMenu.ActiveForm.Hide();
            MyCharity myCharity = new MyCharity();
            myCharity.Show();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}
