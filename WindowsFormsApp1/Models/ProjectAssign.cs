using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        SQLConnect cn = new SQLConnect();
        SqlConnection conn;
        // Fields to be implemented by view.
        public int ProjectID;
        public int EmployeeID;
        public int ProjectRoleID;
        public DateTime StartDate;
        public DateTime EndDate;
        public string Remark;
        // Methods to write and execute queries.
        public BindingList<ProjectAssignData> assignList()
        {
            conn = cn.Connect();
            conn.Open();
            BindingList<ProjectAssignData> list = new BindingList<ProjectAssignData>();
            string sql = "select [200TB_Project].[ProjectID], " +
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
                        project.ProjectName = reader.GetString(1);
                        project.ProjectID = reader.GetInt32(0);
                        project.EmployeeName = reader.GetString(2);
                        project.Role = reader.GetString(3);
                        project.StartDate = reader.GetDateTime(4);
                        project.EndDate = reader.GetDateTime(5);
                        project.Remark = reader.GetString(6);
                        list.Add(project);
                    }
                }
            }
            conn.Close();
            return list;
        }
    }
}
