using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MM_2._0
{
    public partial class send_code : Form
    {
        String randomCode;
        public static string to;

        public send_code()
        {
            InitializeComponent();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            Random r = new Random();
            randomCode = (r.Next(99999)).ToString();
            MailMessage m = new MailMessage();
            to = (guna2TextBox1.Text).ToString();
            from = "matrimonysystem@gmail.com";
            pass = "Loveu_Babyw";
            messageBody = "Your reset Code is   " + randomCode;
            m.To.Add(to);
            m.From = new MailAddress(from);
            m.Body = messageBody;
            m.Subject = "Password ressting code of Matrimony System";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try 
            {
                smtp.Send(m);
                MessageBox.Show("Code Send Sucessfullly");
            }catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login s = new Login();
            s.Show();
        }

        private void guna2GradientButton_verify_Click(object sender, EventArgs e)
        {
            if (randomCode == (guna2TextBox2.Text).ToString())
            {
                to = guna2TextBox1.Text;
                Reset_Pass rp = new Reset_Pass();
                this.Hide();
                rp.Show();
            }
            else 
            {
                MessageBox.Show("Wrong Code.");
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
