using MySql.Data.MySqlClient;
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
    public partial class Event_search : Form
    {
        public Event_search()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
            home start = new home();
            start.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void GridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            E_show ps = new E_show();
            ps.label1.Text = this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            ps.label6.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            ps.label7.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            ps.label8.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            ps.label9.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            //ps.pshowimg.Image = Image.FromFile(@"img\" + this.GridView1.CurrentRow.Cells[5].Value.ToString());
            //       ps.pshowimg.ImageLocation = this.GridView1.CurrentRow.Cells[5].Value.ToString();



            //    ps.pshowimg.Image = Image.FromFile(this.GridView1.CurrentRow.Cells[5].Value.ToString());
            //      MemoryStream ms2 = new MemoryStream();
            //      ps.pshowimg.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
            //ps.pshowimg.ImageLocation = @"\img\"+ this.GridView1.CurrentRow.Cells[5].Value.ToString();

            ps.ShowDialog();

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection dbConnect = new MySqlConnection(appSetting.Connection());
            dbConnect.Open();

            MySqlCommand cmd = new MySqlCommand(" SELECT `Hall Name`,Place, Cost,Number,Details,email FROM `event` WHERE Cost>'" + tk1.SelectedItem.ToString() + "' and Cost<'" + tk2.SelectedItem.ToString() + "' and Place= '" + place1.SelectedItem.ToString() + "'", dbConnect);
           
            MySqlDataAdapter da = new MySqlDataAdapter();

            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tk2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            E_show es = new E_show();
            es.label1.Text = this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            es.label6.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            es.label7.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            es.label8.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            es.label9.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            es.label10.Text = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();


            //es.pshowimg.Image = Image.FromFile(@"img\" + this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString());


            es.ShowDialog();
        }
    }
}
