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
    public partial class date : Form
    {
        public static date instance;
        public date()
        {
            InitializeComponent();
            instance = this;
        }

        private void date_Load(object sender, EventArgs e)
        {

        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            a_user form = new a_user();
            form.Show();
        }
    }
}
