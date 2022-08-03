using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;


namespace MM_2._0
{
    public partial class P_search : Form
    {
        public P_search()
        {
            InitializeComponent();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
            home start = new home();
            start.Show();
        }

        private void guna2ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection dbConnect = new MySqlConnection(appSetting.Connection());
            dbConnect.Open();

            MySqlCommand cmd = new MySqlCommand(" SELECT Name, Age, Height,Number,Birthdate, img FROM `user_regestation` WHERE Gender ='" + gender.SelectedItem.ToString() + "' AND Address ='" + location.SelectedItem.ToString() + "' AND Religion= '" + religion.SelectedItem.ToString() + "' AND Age>'" + age1.SelectedItem.ToString() + "' AND Age<'" + age2.SelectedItem.ToString() + "'", dbConnect);

            MySqlDataAdapter da = new MySqlDataAdapter();

            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            GridView1.DataSource = dt;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PShow ps = new PShow();
            ps.label1.Text = this.GridView1.CurrentRow.Cells[0].Value.ToString();
            ps.label6.Text = this.GridView1.CurrentRow.Cells[1].Value.ToString();
            ps.label7.Text = this.GridView1.CurrentRow.Cells[2].Value.ToString();
            ps.label8.Text = this.GridView1.CurrentRow.Cells[3].Value.ToString();
            ps.label9.Text = this.GridView1.CurrentRow.Cells[4].Value.ToString();
            ps.pshowimg.Image = Image.FromFile(@"img\" + this.GridView1.CurrentRow.Cells[5].Value.ToString());
            //       ps.pshowimg.ImageLocation = this.GridView1.CurrentRow.Cells[5].Value.ToString();



            //    ps.pshowimg.Image = Image.FromFile(this.GridView1.CurrentRow.Cells[5].Value.ToString());
            //      MemoryStream ms2 = new MemoryStream();
            //      ps.pshowimg.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
            //ps.pshowimg.ImageLocation = @"\img\"+ this.GridView1.CurrentRow.Cells[5].Value.ToString();

            ps.ShowDialog();
            
        }

        private void P_search_Load(object sender, EventArgs e)
        {

        }

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
