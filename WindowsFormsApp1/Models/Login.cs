using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    
    class Login: SQLConnect
    {
        public string Username;
        public string Password;
        // Check login credentials
        public int credCheck ()
        {
            Console.WriteLine("Checking user credentials.");
            // Connect to the table then establish connection.
            SQLConnect cn = new SQLConnect();
            SqlConnection conn = cn.Connect();
            conn.Open();
            // Write the query and execute.
            string sql = "select [EmployeeID] " +
                "from [301TB_Email] " +
                "where EmailAddress = '" + this.Username + "' " +
                "and EmployeePass = '" + this.Password + "' " +
                "and DelFlag = 0";
            Console.WriteLine(sql);
            SqlCommand cmd = new SqlCommand(sql,conn);
            if(cmd.ExecuteNonQuery() == 0)
            {
                Console.WriteLine("None found.");
                conn.Close();
                return 0;
            }
            else
            {
                Console.WriteLine("Login Successful.");
                conn.Close();
                return 1;
            }
            
        }
    }
}
