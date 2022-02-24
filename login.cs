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

namespace Matrimony_System_ii
{
    public partial class login : Form
    {
        public static login instance;
        string Connectstring = "datasource = localhost; user_name = root;" +
                " user_password =; database = matrimony system";
        public login()
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
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void user_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void login2_Click(object sender, EventArgs e)
        {
            if(user_name.Text =="" && user_password.Text =="")
            {
                MessageBox.Show("Enter the username & password ");

            }
            else
            {
                //MySqlConnection dbConnect = new MySqlConnection(Connectstring);
                //Database connectin 
                MySqlConnection dbConnect = new MySqlConnection(appSetting.Connection());
                MySqlCommand cmd = new MySqlCommand(" select* from user_login where user_name=@user_name and user_password=@user_password", dbConnect);
                cmd.Parameters.AddWithValue("@user_name", user_name.Text);
                cmd.Parameters.AddWithValue("@user_password", user_password.Text);
                dbConnect.Open();
                MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                dbConnect.Close();

                int count =ds.Tables[0].Rows.Count;
                if(count == 1)
                {
                    home form = new home();
                    form.Show();
                    this.Hide();
                }
                else {
                MessageBox.Show("username or password is incorrect");
                user_name.Clear();
                user_password.Clear();
                user_name.Focus();
                }
            }
        
        }
    }
}
