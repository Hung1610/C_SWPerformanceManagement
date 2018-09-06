﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Presenters;

namespace WindowsFormsApp1.Models
{
    public class ProjectReport
    {
        // Connection String.
        string conStr = ConfigurationManager.ConnectionStrings["connectionString"].ToString();

        //Fields to be assigned by view.
        public DateTime Date;
        public int WorkingTime;
        public string Remark;
        public string ProjectName;
        public int EmployeeID;
        public int ProjectID;
        // Methods to write the queries and execute.
        
        // List containing Project name and ID.
        public List<ProjectAssignData> assignList()
        {
            using(SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                List<ProjectAssignData> list = new List<ProjectAssignData>();
                string sql = "select [201TB_ProjectAssign].[ProjectID]," +
                                    "[200TB_Project].[ProjectName] " +
                    "from [201TB_ProjectAssign] " +
                    "left join [200TB_Project] " +
                    "on [200TB_Project].[ProjectID] = [201TB_ProjectAssign].[ProjectID]";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProjectAssignData project = new ProjectAssignData();
                            project.ProjectName = reader.GetString(1);
                            project.ProjectID = reader.GetInt32(0);
                            list.Add(project);
                        }
                    }
                }
                return list;
            }
        }

        // Insert Working Report into the database.
        public void saveReport()
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
                    command.Parameters.Add("@wHour", SqlDbType.Real).Value = this.WorkingTime;
                    command.Parameters.Add("@wDetail", SqlDbType.NVarChar).Value = this.Remark;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}