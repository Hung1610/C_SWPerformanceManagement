using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_SWInternPerformance.Data;

namespace C_SWInternPerformance.Models
{
    public abstract class BaseModel
    {
        // Connection string.
        public readonly string conStr = ConfigurationManager.ConnectionStrings["connectionString"].ToString();

        // ID search for use in update query.
        public int SearchID(int ID)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "select [ProjectID] " +
                    "from [200TB_Project] " +
                    "where ProjectID = " + ID + " " +
                    "and DelFlag = 0";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        int result = reader.GetInt32(0);
                        return result;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        // Creating a list of projects. Containing ProjectID and ProjectName.
        public BindingList<ProjectsData> ProjectList()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                BindingList<ProjectsData> list = new BindingList<ProjectsData>();
                ProjectsData item = new ProjectsData(-1, "All");
                list.Add(item);
                string sql = "select [ProjectID]," +
                                    "[ProjectName] " +
                    "from [200TB_Project] ";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProjectsData project = new ProjectsData
                            {
                                ProjectName = reader.GetString(1),
                                ProjectID = reader.GetInt32(0)
                            };
                            list.Add(project);
                        }
                    }
                }
                return list;
            }
        }
        
        // Getting a list of employees' names and their ID.
        public BindingList<EmployeeData> GetEmployeeDatas()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                BindingList<EmployeeData> list = new BindingList<EmployeeData>();
                string sql = "SELECT [EmployeeID],[Name] " +
                    "FROM [300TB_Employee]";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeData emp = new EmployeeData
                            {
                                EmployeeID = reader.GetInt32(0),
                                EmployeeName = reader.GetString(1)
                            };
                            list.Add(emp);
                        }
                    }
                }
                return list;
            }
        }

    }
}
