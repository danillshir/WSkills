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
    public partial class RunnerRegister : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        public RunnerRegister()
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
            RunnerRegister.ActiveForm.Hide();
            Form Login = new Login();
            Login.Show();;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RunnerRegister.ActiveForm.Hide();
            Form Login = new Login();
            Login.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RunnerRegister.ActiveForm.Hide();
            RunnerRegistratsia registratsia = new RunnerRegistratsia();
            registratsia.Show();
        }
    }
}
