using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrimony_System_ii
{
    public partial class regestation : Form
    {
        public static regestation instance;
        public regestation()
        {
            InitializeComponent();
            instance = this;
        }

        private void regestation_Load(object sender, EventArgs e)
        {

        }
    }
}
