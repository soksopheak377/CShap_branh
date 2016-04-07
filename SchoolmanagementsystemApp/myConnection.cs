using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SchoolmanagementsystemApp
{
    class myConnection
    {
        public static SqlConnection GetConnection()
        {
            string str = "Data Source=DELL-990/DELL;Initial Catalog=SMsystem;Integrated Security=True";

            SqlConnection con = new SqlConnection(str);
            con.Open();
            return con;
        }
    }
}
