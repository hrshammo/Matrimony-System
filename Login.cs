using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace MM_2._0
{
    public partial class Login : Form
    {
        public static Login instance;
        string Connectstring = "datasource = localhost; user_name = root;" +
                " user_password =; database = matrimony system";
        public Login()
        {
            InitializeComponent();
            instance = this;
        }
        private void DBConnection()
        {
            string Connectstring = "datasource = localhost; user_name = root;" +
                " user_password =; database = matrimony system";
            MySqlConnection DBConnect = new MySqlConnection(Connectstring);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (user_name.Text == "" && user_password.Text == "")
            {
                MessageBox.Show("Enter the Email & password ");

            }
            else
            {
                //MySqlConnection dbConnect = new MySqlConnection(Connectstring);
                //Database connectin 
                MySqlConnection dbConnect = new MySqlConnection(appSetting.Connection());
              //  MySqlCommand cmd = new MySqlCommand(" select* from user_login where user_name=@user_name and user_password=@user_password ", dbConnect);
                MySqlCommand cmd = new MySqlCommand(" select* from user_regestation where Username=@user_name AND User_password=@user_password ", dbConnect);



                cmd.Parameters.AddWithValue("@user_name", user_name.Text);
                cmd.Parameters.AddWithValue("@user_password", user_password.Text);
                dbConnect.Open();
                MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                dbConnect.Close();

               

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    home form = new home();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username or password is incorrect");
                    user_name.Clear();
                    user_password.Clear();
                    user_name.Focus();
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1show.Checked)
            {
                user_password.UseSystemPasswordChar = false;
            }
            else
            {
                user_password.UseSystemPasswordChar = true;
            }
        }

        private void forgot_password_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            send_code s = new send_code();
            s.Show();
        }
    }
}
