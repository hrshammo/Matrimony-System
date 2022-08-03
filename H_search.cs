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
    public partial class H_search : Form
    {
        public H_search()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
            home start = new home();
            start.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection dbConnect = new MySqlConnection(appSetting.Connection());
            dbConnect.Open();

            MySqlCommand cmd = new MySqlCommand(" SELECT `Hotel_name`,Place,Cost,Number,email,Details FROM `hotel` WHERE Cost>'" + tk1.SelectedItem.ToString() + "' and Cost<'" + tk2.SelectedItem.ToString() + "' and place= '" + place1.SelectedItem.ToString() + "'", dbConnect);
           
            MySqlDataAdapter da = new MySqlDataAdapter();

            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            H_show hs = new H_show();
            hs.label1.Text = this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            hs.label6.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            hs.label7.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            hs.label8.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            hs.label10.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            hs.label9.Text = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();


            //es.pshowimg.Image = Image.FromFile(@"img\" + this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString());


            hs.ShowDialog();
        }

        private void H_search_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
