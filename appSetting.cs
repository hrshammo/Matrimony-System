using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_2._0
{
    public static class appSetting
    {


        public static string Connection()
        {
            string constring = "Server = localhost; database = matrimony system; Uid = root; Pwd = ''; SslMode = none";
            return constring;
        }
    }
    
}
