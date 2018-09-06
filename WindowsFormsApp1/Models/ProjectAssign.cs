using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Presenters;

namespace WindowsFormsApp1.Models
{
    class ProjectAssign
    {
        // Connect to the table then establish connection.
        string conStr = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        // Fields to be implemented by view.
        public int ProjectID;
        public int EmployeeID;
        public int ProjectRoleID;
        public DateTime StartDate;
        public DateTime EndDate;
        public string Remark;
        // Methods to write and execute queries.

        // Simple list containing ProjectID and ProjectName
        public BindingList<ProjectsData> getPList()
        {
            using(SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                BindingList<ProjectsData> list = new BindingList<ProjectsData>();
                ProjectsData item = new ProjectsData(-1, "All");
                list.Add(item);
                string sql = "SELECT [201TB_ProjectAssign].[ProjectID], " +
                                    "[200TB_Project].[ProjectName] " +
                    "FROM [200TB_Project] " +
                    "JOIN [201TB_ProjectAssign] on [200TB_Project].ProjectID = [201TB_ProjectAssign].ProjectID ";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProjectsData project = new ProjectsData();
                            project.ProjectID = reader.GetInt32(0);
                            project.ProjectName = reader.GetString(1);
                            list.Add(project);
                        }
                    }
                }
                return list;
            }
        }

        // Getting a complete object list containing all project assign data.
        public BindingList<ProjectAssignData> assignList()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                BindingList<ProjectAssignData> list = new BindingList<ProjectAssignData>();
                string sql = "select [ProjectAssignID], " +
                                    "[201TB_ProjectAssign].[ProjectID], " +
                                    "[201TB_ProjectAssign].[EmployeeID], " +
                                    "[201TB_ProjectAssign].[ProjectRoleID], " +
                                    "[200TB_Project].[ProjectName], " +
                                    "[300TB_Employee].Name, " +
                                    "[202TB_ProjectRole].[ProjectRoleName], " +
                                    "[201TB_ProjectAssign].StartDate, " +
                                    "[201TB_ProjectAssign].EndDate, " +
                                    "[201TB_ProjectAssign].Remark " +
                    "from [200TB_Project] " +
                    "join [201TB_ProjectAssign] on [200TB_Project].ProjectID = [201TB_ProjectAssign].ProjectID " +
                    "join [202TB_ProjectRole] on [201TB_ProjectAssign].ProjectRoleID = [202TB_ProjectRole].ProjectRoleID " +
                    "join [300TB_Employee] on [201TB_ProjectAssign].EmployeeID = [300TB_Employee].EmployeeID ";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProjectAssignData project = new ProjectAssignData();
                            project.ProjectAssignID = reader.GetInt32(0);
                            project.ProjectID = reader.GetInt32(1);
                            project.EmployeeID = reader.GetInt32(2);
                            project.RoleID = reader.GetInt32(3);
                            project.ProjectName = reader.GetString(4);
                            project.EmployeeName = reader.GetString(5);
                            project.Role = reader.GetString(6);
                            project.StartDate = reader.GetDateTime(7);
                            project.EndDate = reader.GetDateTime(8);
                            project.Remark = reader.GetString(9);
                            list.Add(project);
                        }
                    }
                }
                return list;
            }
        }
    }
}
