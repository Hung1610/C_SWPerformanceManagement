using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    
    class Login
    {
        public string Username;
        public string Password;
        // Check login credentials
        SQLConnect cn = new SQLConnect();
        public int credCheck ()
        {
            Console.WriteLine("Checking user credentials.");
            // Connect to the table then establish connection.
            
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
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                
                if (reader.HasRows && reader.Read())
                {
                    Console.WriteLine("Login Successful.");
                    int ID = reader.GetInt32(0);
                    conn.Close();
                    return ID;
                    
                }
                else
                {
                    Console.WriteLine("None found.");
                    conn.Close();
                    return 0;
                }

            }

        }
    }
}
