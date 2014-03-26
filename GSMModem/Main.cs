using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace GSMModem
{
    class Main
    {
        public static SqlConnection GetDBConnection()
        {
            Operation ipconf = new Operation();
            string path = Directory.GetCurrentDirectory();
            string path1 = ""; //ipconf.ipconfig(path + "\\" + "IPCONFG.txt");
            string strerverIP = "192.168.1.15";

            // Define the Access Database driver and the filename of the database
            SqlConnection conn = new SqlConnection(
        "Data Source=" + strerverIP + @"\PGJE;Initial Catalog=SGAP;User ID=sa;Password=12345");
            return conn;
        }
    }
}
