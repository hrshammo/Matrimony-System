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
    public partial class PG_show : Form
    {
        String Date_box;
        public static string to;
        public PG_show()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            //guna2TextBox1 h = new guna2textBox1();
            //guna2textBox1 = h.guna2TextBox1.ToString();
            MailMessage m = new MailMessage();
            to = (label10.Text).ToString();
            from = "matrimonysystem@gmail.com";
            pass = "Loveu_Baby";
            messageBody = "You have a Booking requst for " + label1.Text + " on   " + guna2ComboBox6.SelectedItem.ToString() + " " + guna2ComboBox7.SelectedItem.ToString() + " " + guna2ComboBox1.SelectedItem.ToString() + "";
            m.To.Add(to);
            m.From = new MailAddress(from);
            m.Body = messageBody;
            m.Subject = "Event Photography Booking requst of Matrimony System";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(m);
                MessageBox.Show("Booked Sucessfullly");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhotoG_search start = new PhotoG_search();
            start.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
