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
using System.Data.SqlClient;
using MongoDB.Driver.Core.Configuration;

namespace MM_2._0
{
    public partial class Reset_Pass : Form
    {
        public Reset_Pass()
        {
            InitializeComponent();
        }
        //Database connection 
        public static Login instance;
        string Connectstring = "datasource = localhost; user_name = root;" +
                " user_password =; database = matrimony system";

        //db con end 
        private void DBConnection()
        {
            string Connectstring = "datasource = localhost; user_name = root;" +
                " user_password =; database = matrimony system";
            MySqlConnection DBConnect = new MySqlConnection(Connectstring);
        }
        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(appSetting.Connection());
            con.Open();
            MySqlCommand cmd;
            
            cmd = con.CreateCommand();

          //  cmd.CommandText = "INSERT INTO user_regestation( Name,User_password,Address,Number,Gender,Age,Height,Birthdate,Religion,Username,img) VALUES  ('" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "')";
            
            cmd.CommandText = "UPDATE user_regestation SET User_password = '" + guna2TextBox1.Text + "' WHERE Username='" + guna2TextBox2.Text + "'";
            
            
            cmd.Parameters.AddWithValue("@User_password", guna2TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@Username", guna2TextBox2.Text.Trim());
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Changed Sucessfully ! ");
                this.Hide();
                Login login = new Login();
                login.Show();
               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
