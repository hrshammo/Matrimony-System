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
    public partial class PhotoG_search : Form
    {
        public PhotoG_search()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection dbConnect = new MySqlConnection(appSetting.Connection());
            dbConnect.Open();
           
            MySqlCommand cmd = new MySqlCommand(" SELECT package,company,price,place,email,details FROM `photo` WHERE price>'" + tk1.SelectedItem.ToString() + "' and price<'" + tk2.SelectedItem.ToString() + "' and place= '" + place1.SelectedItem.ToString() + "'", dbConnect);
            //price>'"+tk1.SelectedItem.ToString()+ "' and price<'" + tk2.SelectedItem.ToString() + "' and 
            
            
            //  MySqlCommand cmd = new MySqlCommand(" SELECT* FROM `photo` WHERE place='"+place2.Text+ "';", dbConnect);

            //  MySqlCommand cmd = new MySqlCommand(" SELECT* FROM `photo` WHERE price>30000", dbConnect);


            /* cmd.Parameters.AddWithValue("@price", tk1.Text.Trim());
            cmd.Parameters.AddWithValue("@price", tk2.Text.Trim());
            cmd.Parameters.AddWithValue("@place", place1);
*/

            MySqlDataAdapter da = new MySqlDataAdapter();
            
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PG_show pg = new PG_show();
            pg.label1.Text = this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            pg.label6.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            pg.label7.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            pg.label8.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            pg.label10.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            pg.label9.Text = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();


            pg.Show();
        }
     
        private void PhotoG_search_Load(object sender, EventArgs e)
        {

        }

        

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            PG_show pg= new PG_show();

            pg.label1.Text = this.guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            pg.label6.Text = this.guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            pg.label7.Text = this.guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            pg.label8.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            pg.label10.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            pg.label9.Text = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();


            pg.Show();

        }
    }
}
