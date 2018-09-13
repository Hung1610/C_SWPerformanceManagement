using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace C_SWInternPerformance.Models
{
    
    class Login:BaseModel
    {
        public string Username;
        public string Password;
        //
        // Checking User Credetials from input.
        public int CredCheck ()
        {
            Console.WriteLine("Checking user credentials.");
            // Connect to the table then establish connection.
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                // Write the query and execute.
                string sql = "SELECT [EmployeeID] " +
                    "FROM [301TB_Email] " +
                    "WHERE EmailAddress = '" + this.Username + "' " +
                    "AND EmployeePass = '" + this.Password + "' " +
                    "AND DelFlag = 0";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // If cred found => return first result.
                    if (reader.HasRows && reader.Read())
                    {
                        Console.WriteLine("Login Successful.");
                        int ID = reader.GetInt32(0);
                        return ID;

                    }
                    // else return 0.
                    else
                    {
                        Console.WriteLine("None found.");
                        return 0;
                    }
                }
            }
           
        }
        public string GetUser(int ID)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                // Write the query and execute.
                string sql = "SELECT Name " +
                    "FROM [300TB_Employee] Employee " +
                    "JOIN [301TB_Email] Email " +
                    "ON Employee.EmployeeID = Email.EmployeeID " +
                    "WHERE Email.EmployeeID = " + ID;
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    string name = reader.GetString(0);
                    return name;
                }
            }
        }
    }
}
