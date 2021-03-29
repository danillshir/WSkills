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
    public partial class EditCharity : Form
    {
        public string email;
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 8);
        public EditCharity(string email)
        {
            this.email = email;
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
            EditCharity.ActiveForm.Hide();
            MenuAdm menuAdm = new MenuAdm();
            menuAdm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditCharity.ActiveForm.Hide();

        }
    }
}
