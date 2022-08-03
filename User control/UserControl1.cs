using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using MongoDB.Driver.Core.Configuration;

namespace MM_2._0.User_control
{
    
    public partial class UserControl1 : UserControl
    {
        string gender;
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
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            //FileStream fs;
           // BinaryReader br;
            //using(SqlConnection conn = new SqlConnection(ConnectionString))
            MySqlConnection con = new MySqlConnection(appSetting.Connection());
            //{

            // pictureBox1.Image.Save( pictureBox1.Image.RawFormat);
            /* string FileName = pictureBox1.Text;
             byte[] ImageData;
             fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
             br = new BinaryReader(fs);//eror
             ImageData = br.ReadBytes((int)fs.Length);
             br.Close();
             fs.Close();
            */
           // MemoryStream ms = new MemoryStream();
           // pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            //byte[] userImg = ms.ToArray();

            con.Open();


            //SqlCommand cmd = new SqlCommand("user_regestation", con);
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            // cmd.CommandText = "INSERT INTO `user_regestation VALUES  Name=@name , User_password=@user_password, Address=@address, Number=@number, Age=@age, Height=@height, Birthdate=@birthdate, Religion=@religion, User_name=@username ";

          //  cmd.CommandText = "INSERT INTO user_regestation(userImg, Name,User_password,Address,Number,Gender,Age,Height,Birthdate,Religion,Username,img) VALUES  (@userImg ,@name,@user_password,@address,@number,@gender,@age,@height, @birthdate,@religion,@username, @'"+Path.GetFileName(pictureBox1.ImageLocation)+"')";
         //   cmd.CommandText = "INSERT INTO user_regestation( Name,User_password,Address,Number,Gender,Age,Height,Birthdate,Religion,Username,img) VALUES  (@name,@user_password,@address,@number,@gender,@age,@height, @birthdate,@religion,@username, @'"+Path.GetFileName(pictureBox1.ImageLocation)+"')";
            cmd.CommandText = "INSERT INTO user_regestation( Name,User_password,Address,Number,Gender,Age,Height,Birthdate,Religion,Username,img) VALUES  ('" +name.Text + "','" +user_password.Text + "','" +address.Text + "','" +number.Text + "','" +gender + "','" + age.Text+ "','" + height.Text+ "', '" +birthdate.Text + "','" + religion.Text+ "','" + user_name.Text + "', '" + Path.GetFileName(pictureBox1.ImageLocation)+"')";
                                                                                                                                                                                




            //cmd.CommandType= CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@userImg", pictureBox1);
            //  cmd.Parameters.AddWithValue("@userImg", pictureBox1.Image);
            cmd.Parameters.AddWithValue("@Name",name.Text.Trim());
                cmd.Parameters.AddWithValue("@User_password", user_password.Text.Trim());
                 
                 cmd.Parameters.AddWithValue("@Address", address.Text.Trim());
                 cmd.Parameters.AddWithValue("@Number", number.Text.Trim());
            cmd.Parameters.AddWithValue("@Gender", gender);

            cmd.Parameters.AddWithValue("@Age", age.Text.Trim());
                 cmd.Parameters.AddWithValue("@Height", height.Text.Trim());
                 cmd.Parameters.AddWithValue("@Birthdate", birthdate.Text.Trim());
                 cmd.Parameters.AddWithValue("@Religion", religion.Text.Trim());
                 cmd.Parameters.AddWithValue("@Username", user_name.Text.Trim());
             cmd.Parameters.AddWithValue("@img", Path.GetFileName(pictureBox1.ImageLocation).Trim());

            //    cmd.Parameters.AddWithValue("@photo", user_name.Text.Trim());
            //    cmd.Parameters.AddWithValue("@gender", gender.Text.Trim());
         //   File.Copy(imageText.Text,Application.StartupPath + @"\img\"+Path.GetFileName(pictureBox1.ImageLocation));
          
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                File.Copy(imageText.Text, Application.StartupPath + @"\img\" + Path.GetFileName(pictureBox1.ImageLocation));
                
                MessageBox.Show("Sumbit done ! ");

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            //}

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        string photopath;
        byte[] binaryphoto;
        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg|Jpegs|*.Jpegs|png|*.png|Bitmaps|*Bitmaps";
            file.Title = "Please Select an Image";
            if (file.ShowDialog() == DialogResult.OK)
            {
                /* pictureBox1.Image = new Bitmap(file.OpenFile());
                 photopath = file.FileName;
                 FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                 BinaryReader br = new BinaryReader(fs);
                 binaryphoto = br.ReadBytes((int)fs.Length);
                 fs.Close();
                */
                imageText.Text = file.FileName;
                pictureBox1.Image = new Bitmap(file.FileName);
                pictureBox1.ImageLocation = file.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            }
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void user_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
