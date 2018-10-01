using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_SWInternPerformance.Data;
using C_SWInternPerformance.Presenters;

namespace C_SWInternPerformance.Models
{
    class Projects:BaseModel
    {
        // Fields to be implemented by view.
        public string ProjectName;
        public string ProjectInfo;
        public string CustomerName;
        public string CustomerInfo;
        public string Remark;
        public DateTime StartDate;
        public DateTime EndDate;
        // Methods to write the queries and execute.
        //
        // INSERT a new project into the database.
        public void AddProject()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "Execute AddProject @pName,@pInfo,@cName,@cInfo,@startDate,@endDate,@del,@remark";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@pName", SqlDbType.NVarChar).Value = this.ProjectName;
                    command.Parameters.Add("@pInfo", SqlDbType.NVarChar).Value = this.ProjectInfo;
                    command.Parameters.Add("@cName", SqlDbType.NVarChar).Value = this.CustomerName;
                    command.Parameters.Add("@cInfo", SqlDbType.NVarChar).Value = this.CustomerInfo;
                    command.Parameters.Add("@startDate", SqlDbType.Date).Value = this.StartDate;
                    command.Parameters.Add("@endDate", SqlDbType.Date).Value = this.EndDate;
                    command.Parameters.Add("@del", SqlDbType.Int).Value = 0;
                    command.Parameters.Add("@remark", SqlDbType.NVarChar).Value = this.Remark;
                    command.ExecuteNonQuery();
                }
            }
        }

        // UPDATE the project with new data based on input ID.
        public void SaveProject(int ID)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "Execute SaveProject @pName,  @pInfo, @cName, @cInfo, @startDate, @endDate, @remark, @ID";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@pName", SqlDbType.NVarChar).Value = this.ProjectName;
                    command.Parameters.Add("@pInfo", SqlDbType.NVarChar).Value = this.ProjectInfo;
                    command.Parameters.Add("@cName", SqlDbType.NVarChar).Value = this.CustomerName;
                    command.Parameters.Add("@cInfo", SqlDbType.NVarChar).Value = this.CustomerInfo;
                    command.Parameters.Add("@startDate", SqlDbType.Date).Value = this.StartDate;
                    command.Parameters.Add("@endDate", SqlDbType.Date).Value = this.EndDate;
                    command.Parameters.Add("@remark", SqlDbType.NVarChar).Value = this.Remark;
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    command.ExecuteNonQuery();
                }
            }
        }
        
        // Return project data from database for use in work form.
        public (string pName, string pInfo,string cName,string cInfo, string remark,DateTime start,DateTime end) GetProject(int ID)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "Execute GetProject @ID";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        return (reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), reader.GetDateTime(6));
                    }
                    else
                    {
                        return ("","", "", "", "", DateTime.Now, DateTime.Now);
                    }
                }
            }
        }
    }
}
