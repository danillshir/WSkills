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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }

        private void crossPictureBox_Click(object sender, EventArgs e)
        {
            Report.ActiveForm.Close();
        }

        private void Report_Load(object sender, EventArgs e)
        {
           
        }
    }
}
