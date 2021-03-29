using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSkills
{
    public partial class Form1 : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Runer.RunnerRegister runnerRegister = new Runer.RunnerRegister();
            runnerRegister.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form RunnerSponsor = new RunnerSponsor();
            RunnerSponsor.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
            label3.Text = DateTime.Today.ToString("dd.MM.yyyy");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form Information = new MoreInformation.Information();
            Information.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form Login = new Login();
            Login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
