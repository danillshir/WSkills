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
    public partial class HowLongIsAMarathon : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        public HowLongIsAMarathon()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            labelTime.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label3.Text = label13.Text;
            pictureBox1.Image = pictureBox2.Image;
            label14.Text = "Максимальная скорость F1 Car 345km/h. Это займет\n 12 минут, чтобы завершить 42km марафон.";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label3.Text = label12.Text;
            pictureBox1.Image = pictureBox3.Image;
            label14.Text = "Максимальная скорость Worm 0.03km/h. Это займет\n 1400 часов, чтобы завершить 42km марафон.";
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label3.Text = label13.Text;
            pictureBox1.Image = pictureBox2.Image;
            label14.Text = "Максимальная скорость F1 Car 345km/h. Это займет\n 12 минут, чтобы завершить 42km марафон.";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label3.Text = label12.Text;
            pictureBox1.Image = pictureBox3.Image;
            label14.Text = "Максимальная скорость Worm 0.03km/h. Это займет\n 1400 часов, чтобы завершить 42km марафон.";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label3.Text = label11.Text;
            pictureBox1.Image = pictureBox4.Image;
            label14.Text = "Максимальная скорость Sloth 0.12km/h. Это займет\n 350 часов, чтобы завершить 42km марафон.";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label3.Text = label11.Text;
            pictureBox1.Image = pictureBox4.Image;
            label14.Text = "Максимальная скорость Sloth 0.12km/h. Это займет\n 350 часов, чтобы завершить 42km марафон.";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label3.Text = label10.Text;
            pictureBox1.Image = pictureBox5.Image;
            label14.Text = "Максимальная скорость Capybara 35km/h. Это займет\n 1,2 часа, чтобы завершить 42km марафон.";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label3.Text = label10.Text;
            pictureBox1.Image = pictureBox5.Image;
            label14.Text = "Максимальная скорость Capybara 35km/h. Это займет\n 1,2 часа, чтобы завершить 42km марафон.";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label3.Text = label9.Text;
            pictureBox1.Image = pictureBox10.Image;
            label14.Text = "Максимальная скорость Jaguar 80km/h. Это займет\n 31,5 минут, чтобы завершить 42km марафон.";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label3.Text = label9.Text;
            pictureBox1.Image = pictureBox10.Image;
            label14.Text = "Максимальная скорость Jaguar 80km/h. Это займет\n 31,5 минут, чтобы завершить 42km марафон.";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label3.Text = label15.Text;
            pictureBox1.Image = pictureBox12.Image;
            label14.Text = "Максимальная скорость Horse 15km/h. Это займет\n 2,8 часа, чтобы завершить 42km марафон.";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label3.Text = label15.Text;
            pictureBox1.Image = pictureBox12.Image;
            label14.Text = "Максимальная скорость Horse 15km/h. Это займет\n 2,8 часа, чтобы завершить 42km марафон.";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label3.Text = label16.Text;
            pictureBox1.Image = pictureBox13.Image;
            label14.Text = "Максимальная скорость Slug 0.01km/h. Это займет\n 4200 часов, чтобы завершить 42km марафон.";
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label3.Text = label16.Text;
            pictureBox1.Image = pictureBox13.Image;
            label14.Text = "Максимальная скорость Slug 0.01km/h. Это займет\n 4200 часов, чтобы завершить 42km марафон.";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label3.Text = label4.Text;
            pictureBox1.Image = pictureBox9.Image;
            label14.Text = "Длина AirBus A380 73m. Это займет 576\n из них, чтобы покрыть расстояние в 42км марафона";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label3.Text = label4.Text;
            pictureBox1.Image = pictureBox9.Image;
            label14.Text = "Длина AirBus A380 73m. Это займет 576\n из них, чтобы покрыть расстояние в 42км марафона";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label3.Text = label5.Text;
            pictureBox1.Image = pictureBox8.Image;
            label14.Text = "Длина Pair of Havaianas 0.245m. Это займет 171429\n из них, чтобы покрыть расстояние в 42км марафона";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label3.Text = label5.Text;
            pictureBox1.Image = pictureBox8.Image;
            label14.Text = "Длина Pair of Havaianas 0.245m. Это займет 171429\n из них, чтобы покрыть расстояние в 42км марафона";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label3.Text = label6.Text;
            pictureBox1.Image = pictureBox7.Image;
            label14.Text = "Длина Football Field 105m. Это займет 400\n из них, чтобы покрыть расстояние в 42км марафона";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label3.Text = label6.Text;
            pictureBox1.Image = pictureBox7.Image;
            label14.Text = "Длина Football Field 105m. Это займет 400\n из них, чтобы покрыть расстояние в 42км марафона";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label3.Text = label7.Text;
            pictureBox1.Image = pictureBox6.Image;
            label14.Text = "Длина Ronaldinho 1.81m. Это займет 23205\n из них, чтобы покрыть расстояние в 42км марафона";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label3.Text = label7.Text;
            pictureBox1.Image = pictureBox6.Image;
            label14.Text = "Длина Ronaldinho 1.81m. Это займет 23205\n из них, чтобы покрыть расстояние в 42км марафона";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label3.Text = label8.Text;
            pictureBox1.Image = pictureBox11.Image;
            label14.Text = "Длина Bus 10m. Это займет 4200\n из них, чтобы покрыть расстояние в 42км марафона";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label3.Text = label8.Text;
            pictureBox1.Image = pictureBox11.Image;
            label14.Text = "Длина Bus 10m. Это займет 4200\n из них, чтобы покрыть расстояние в 42км марафона";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Information = new MoreInformation.Information();
            Information.Show();
            Close();
        }

        private void HowLongIsAMarathon_Load(object sender, EventArgs e)
        {

        }
    }
}
