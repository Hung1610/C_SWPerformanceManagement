﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    class ProjectAssign:BaseModel
    {
        // Fields to be implemented by view.
        public int ProjectAssignID;
        //public int ProjectID;
        public int EmployeeID;
        public int ProjectRoleID;
        public DateTime StartDate;
        public DateTime EndDate;
        public string Remark;
        // Methods to write and execute queries.
        
        // Getting a list of roles and their ID.
        public BindingList<RoleData> GetRoleDatas()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                BindingList<RoleData> list = new BindingList<RoleData>();
                string sql = "Execute GetRoleData";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RoleData role = new RoleData
                            {
                                RoleID = reader.GetInt32(0),
                                RoleName = reader.GetString(1)
                            };
                            list.Add(role);
                        }
                    }
                }
                return list;
            }
        }

        // Getting a complete object list containing all project assign data.
        public BindingList<ProjectAssignData> AssignList()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                BindingList<ProjectAssignData> list = new BindingList<ProjectAssignData>();
                string sql = "Execute AssignList ";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProjectAssignData project = new ProjectAssignData
                            {
                                ProjectAssignID = reader.GetInt32(0),
                                ProjectID = reader.GetInt32(1),
                                EmployeeID = reader.GetInt32(2),
                                RoleID = reader.GetInt32(3),
                                ProjectName = reader.GetString(4),
                                EmployeeName = reader.GetString(5),
                                Role = reader.GetString(6),
                                StartDate = reader.GetDateTime(7),
                                EndDate = reader.GetDateTime(8),
                                Remark = reader.GetString(9)
                            };
                            list.Add(project);
                        }
                    }
                }
                return list;
            }
        }

        // Add new project assignment data into database.
        public void AddAssign(int ID)
        {
            using(SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "Execute AddAssign @pID,@eID,@rID,@startDate,@endDate,@remark";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@pID", SqlDbType.Int).Value = ID;
                    command.Parameters.Add("@eID", SqlDbType.Int).Value = this.EmployeeID;
                    command.Parameters.Add("@rID", SqlDbType.Int).Value = this.ProjectRoleID;
                    command.Parameters.Add("@startDate", SqlDbType.Date).Value = this.StartDate;
                    command.Parameters.Add("@endDate", SqlDbType.Date).Value = this.EndDate;
                    command.Parameters.Add("@remark", SqlDbType.NVarChar).Value = this.Remark;
                    command.ExecuteNonQuery();
                }
            }
        }

        // Delete project assignement from database.
        public void DeleteAssign(int ProjectAssignID)
        {
            using(SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "Execute DeleteAssign @paID";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@paID", SqlDbType.Int).Value = ProjectAssignID;
                    command.ExecuteNonQuery();
                }
            }
        }

        // Save the changed datas to the database.
        public void UpdateAssign(ProjectAssignData projectAssign)
        {
            using(SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "UpdateAssign @paID , @pID , @eID , @rID , @startDate , @endDate , @remark";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@paID", SqlDbType.Int).Value = projectAssign.ProjectAssignID;
                    command.Parameters.Add("@pID", SqlDbType.Int).Value = projectAssign.ProjectID;
                    command.Parameters.Add("@eID", SqlDbType.Int).Value = projectAssign.EmployeeID;
                    command.Parameters.Add("@rID", SqlDbType.Int).Value = projectAssign.RoleID;
                    command.Parameters.Add("@startDate", SqlDbType.Date).Value = projectAssign.StartDate;
                    command.Parameters.Add("@endDate", SqlDbType.Date).Value = projectAssign.EndDate;
                    command.Parameters.Add("@remark", SqlDbType.NVarChar).Value = projectAssign.Remark;
                    command.ExecuteNonQuery();
                    
                }
            }
        }
    }
}
