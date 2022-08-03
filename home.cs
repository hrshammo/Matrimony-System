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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TileButton_signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            P_search e_serach = new P_search();
            e_serach.Show();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
         // this.Hide();
         // E_show w = new E_show();
         // w.Show();
          this.Hide();
            Event_search ev_serach = new Event_search();
            ev_serach.Show();
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
          /*  this.Hide();
            PG_show w = new PG_show();
            w.Show();*/
            this.Hide();
            PhotoG_search pg_serach = new PhotoG_search();
            pg_serach.Show();
        }
            

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
         /*   this.Hide();
            H_show w = new H_show();
            w.Show();
         */
            this.Hide();
            H_search h_serach = new H_search();
            h_serach.Show();
        }

        private void guna2TileButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile start = new profile();
            start.Show();
        }
    }
}
