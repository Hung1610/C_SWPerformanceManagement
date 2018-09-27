using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

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
                string sql = "Execute CredCheck @user,@pass";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = Username;
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Password;
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
                string sql = "Execute GetUser @ID";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
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
