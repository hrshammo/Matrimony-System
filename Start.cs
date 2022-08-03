using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_2._0
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }


        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg reg = new Reg();
            reg.Show();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
