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

namespace Matrimony_System_ii
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Hide();
        }

        private void Regestation_Click(object sender, EventArgs e)
        {
            regestation form = new regestation();   
            form.Show();
            this.Hide();
        }
    }
}
