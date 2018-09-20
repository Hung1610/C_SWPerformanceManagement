using C_SWInternPerformance.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Models
{
    class Profile:BaseModel
    {
        // Fields to be implemented by view.
        public int ID;
        public string Email;
        public string Password;
        public string Remark;
        public int Del;
        // SQL queries.
        //
        // Get ONE profile by user ID.
        public ProfileData GetProfile(int ID)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "SELECT * " +
                    "FROM [301TB_Email] " +
                    "WHERE EmployeeID = " + ID;
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        ProfileData profile = new ProfileData
                        {
                            EmailID = reader.GetInt32(0),
                            EmailAddress = reader.GetString(1),
                            EmployeeID = reader.GetInt32(2),
                            Password = reader.GetString(3),
                            DelFlag = (int)reader.GetByte(4),
                            Remark = reader.GetString(5)
                        };
                        return profile;
                    }
                    else
                        return null;
                }
            }
        }

        // Save the editted Profile.
        public void SaveProfile()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "UPDATE [301TB_Email] " +
                        "SET " +
                        "EmailAddress = @eAddress, " +
                        "EmployeePass = @pass, " +
                        "DelFlag = @del, " +
                        "Remark = @remark " +
                        "WHERE EmployeeID = @eID";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@eAddress", SqlDbType.NVarChar).Value = this.Email;
                    command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = this.Password;
                    command.Parameters.Add("@del", SqlDbType.TinyInt).Value = this.Del;
                    command.Parameters.Add("@remark", SqlDbType.NVarChar).Value = this.Remark;
                    command.Parameters.Add("@eID", SqlDbType.Int).Value = this.ID;
                    command.ExecuteNonQuery();
                }
            }
        }

        // Check for existing emails.
        public int EmailCheck()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "SELECT * " +
                    "FROM [301TB_Email] " +
                    "WHERE EmailAddress = @email " +
                    "AND EmployeeID <> @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = this.Email;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = this.ID;
                Console.WriteLine(sql);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return 0;
                    }
                    else return 1;
                }
            }
        }
    }
}
