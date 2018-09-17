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
    public class ProjectReport:BaseModel
    {
        //Fields to be assigned by view.
        public DateTime Date;
        public Double WorkingTime;
        public string Remark;
        public string ProjectName;
        public int EmployeeID;
        public int ProjectID;
        // Methods to write the queries and execute.

        // Insert Working Report into the database.
        public void SaveReport()
        {
            using(SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "insert into [100TB_Performance]([ProjectID],[EmployeeID],[WorkingDate],[WorkingHour],[WorkingName],[WorkingDetail]) " +
                    "values (@pID,@eID,@wDate,@wHour,@wName,@wDetail)";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@wName", SqlDbType.NVarChar).Value = this.ProjectName;
                    command.Parameters.Add("@pID", SqlDbType.Int).Value = this.ProjectID;
                    command.Parameters.Add("@eID", SqlDbType.Int).Value = this.EmployeeID;
                    command.Parameters.Add("@wDate", SqlDbType.Date).Value = this.Date;
                    command.Parameters.Add("@wHour", SqlDbType.Float).Value = this.WorkingTime;
                    command.Parameters.Add("@wDetail", SqlDbType.NVarChar).Value = this.Remark;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
