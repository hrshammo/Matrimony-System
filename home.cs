using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrimony_System_ii
{
    public partial class home : Form
    {
        public static home instance;
        public home()
        {
            InitializeComponent();
            instance = this;
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            a_user form = new a_user();
            form.Show();
            this.Hide();
        }

        private void date_btn_Click(object sender, EventArgs e)
        {
            date form = new date();
            form.Show();
            this.Hide();
        }
    }
}
