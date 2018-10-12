using C_SWInternPerformance.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Models
{
    class Main:BaseModel
    {
        // Fields to be implemented by view.
        public int UserID;

        // Get user rights.
        public string GetRights()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string result = "";
                string sql = "Execute GetRights @uID";
                Console.WriteLine(sql);
                using(SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@uID", SqlDbType.Int).Value = UserID;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result += "r" + reader.GetInt32(0) + " ";
                        }
                    }
                }
                Console.WriteLine(result);
                return result;
            }
        }

        // Get performance list.
        public BindingList<PerformanceData> GetPerfList()
        {

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                BindingList<PerformanceData> list = new BindingList<PerformanceData>();
                string sql = "Execute GetPerfList";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PerformanceData project = new PerformanceData
                            {
                                PerformanceID = reader.GetInt32(0),
                                EmployeeID = reader.GetInt32(1),
                                ProjectID = reader.GetInt32(2),
                                WorkingDate = reader.GetDateTime(3),
                                WorkingHour = reader.GetDouble(4),
                                WorkingDetail = reader.GetString(6),
                                EmployeeName = reader.GetString(7),
                                ProjectName = reader.GetString(8)
                            };
                            list.Add(project);
                        }
                    }
                }
                return list;
            }
        }
    }
}
