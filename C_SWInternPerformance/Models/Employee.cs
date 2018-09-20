using C_SWInternPerformance.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Models
{
    class Employee:BaseModel
    {
        // Fields to be implemented by view.
        public int EmployeeID;
        public string EmployeeName;
        public int PositionID;
        public int BranchID;
        public DateTime StartDate;
        public DateTime EndDate;
        public string Email;
        public string Mobile;
        public string Address;
        public DateTime Birthday;
        public int LevelID;
        public string Desire;
        public int Del;
        public string Remark;
        // SQL queries.
        //
        // Get ONE employee data based on input ID.
        public DetailedEmployeeData GetEmployee(int ID)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "SELECT * " +
                    "FROM [300TB_Employee] " +
                    "WHERE EmployeeID = " + ID;
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        DateTime end = new DateTime();
                        if (!reader.IsDBNull(5))
                        {
                            end = reader.GetDateTime(5);
                        }
                        else
                        {
                            end = DateTime.Now;
                        }
                        DetailedEmployeeData employee = new DetailedEmployeeData
                        {
                            EmployeeID = ID,
                            EmployeeName = reader.GetString(1),
                            PositionID = reader.GetInt32(2),
                            BranchID = reader.GetInt32(3),
                            StartDate = reader.GetDateTime(4),
                            EndDate = end,
                            Email = reader.GetString(6),
                            Mobile = reader.GetString(7),
                            Address = reader.GetString(8),
                            Birthday = reader.GetDateTime(9),
                            LevelID = reader.GetInt32(10),
                            Desire = reader.GetString(11),
                            Del =(int) reader.GetByte(12),
                            Remark = reader.GetString(13)
                        };
                        return employee;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        // Get a list of Positions.
        public BindingList<PositionData> PositionList()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                BindingList<PositionData> list = new BindingList<PositionData>();
                string sql = "SELECT [PositionID], " +
                    "[PositionName] " +
                    "FROM [303TB_Position]";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PositionData position = new PositionData
                            {
                                PositionID = reader.GetInt32(0),
                                PositionName = reader.GetString(1)
                            };
                            list.Add(position);
                        }
                    }
                }
                return list;
            }
        }

        // List of branches.
        public BindingList<BranchData> BranchList()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                BindingList<BranchData> list = new BindingList<BranchData>();
                string sql = "SELECT [BranchID], " +
                    "[Name] " +
                    "FROM [400TB_Branch]";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BranchData branch = new BranchData
                            {
                                BranchID = reader.GetInt32(0),
                                BranchName = reader.GetString(1)
                            };
                            list.Add(branch);
                        }
                    }
                }
                return list;
            }
        }

        // List of levels.
        public BindingList<LevelData> LevelList()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                BindingList<LevelData> list = new BindingList<LevelData>();
                string sql = "SELECT [LevelID], " +
                    "[Name] " +
                    "FROM [302TB_Level]";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LevelData level = new LevelData
                            {
                                LevelID = reader.GetInt32(0),
                                LevelName = reader.GetString(1)
                            };
                            list.Add(level);
                        }
                    }
                }
                return list;
            }
        }

        // UPDATE the Employee based on input data.
        public void SaveEmployee()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "UPDATE [300TB_Employee] " +
                    "SET " +
                    "Name = @eName, " +
                    "PositionID = @posID, " +
                    "BranchID = @braID, " +
                    "StartDate = @startDate, " +
                    "EndDate = @endDate, " +
                    "EmailPrivate = @email, " +
                    "Mobile = @mobile, " +
                    "Address = @address, " +
                    "BirthDay = @birth, " +
                    "LevelID = @lvlID, " +
                    "Desire = @desire, " +
                    "DelFlag = @del, " +
                    "Remark = @remark " +
                    "WHERE EmployeeID = @proID";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@eName", SqlDbType.NVarChar).Value = this.EmployeeName;
                    command.Parameters.Add("@posID", SqlDbType.Int).Value = this.PositionID;
                    command.Parameters.Add("@braID", SqlDbType.Int).Value = this.BranchID;
                    command.Parameters.Add("@startDate", SqlDbType.Date).Value = this.StartDate;
                    command.Parameters.Add("@endDate", SqlDbType.Date).Value = this.EndDate;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = this.Email;
                    command.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = this.Mobile;
                    command.Parameters.Add("@address", SqlDbType.NVarChar).Value = this.Address;
                    command.Parameters.Add("@birth", SqlDbType.Date).Value = this.Birthday;
                    command.Parameters.Add("@lvlID", SqlDbType.Int).Value = this.LevelID;
                    command.Parameters.Add("@desire", SqlDbType.NVarChar).Value = this.Desire;
                    command.Parameters.Add("@del", SqlDbType.TinyInt).Value = this.Del;
                    command.Parameters.Add("@remark", SqlDbType.NVarChar).Value = this.Remark;
                    command.Parameters.Add("@proID", SqlDbType.Int).Value = this.EmployeeID;
                    command.ExecuteNonQuery();
                }
            }
        }

        // INSERT a new Employee into the database based on input data.
        public void AddEmployee()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "INSERT INTO [300TB_Employee](Name,PositionID,BranchID,StartDate,EndDate,EmailPrivate,Mobile,Address,BirthDay,LevelID,Desire,DelFlag,Remark) " +
                    "VALUES (@eName,@posID,@braID,@startDate,@endDate,@email,@mobile,@address,@birth,@lvlID,@desire,@del,@remark)";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@eName", SqlDbType.NVarChar).Value = this.EmployeeName;
                    command.Parameters.Add("@posID", SqlDbType.Int).Value = this.PositionID;
                    command.Parameters.Add("@braID", SqlDbType.Int).Value = this.BranchID;
                    command.Parameters.Add("@startDate", SqlDbType.Date).Value = this.StartDate;
                    command.Parameters.Add("@endDate", SqlDbType.Date).Value = this.EndDate;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = this.Email;
                    command.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = this.Mobile;
                    command.Parameters.Add("@address", SqlDbType.NVarChar).Value = this.Address;
                    command.Parameters.Add("@birth", SqlDbType.Date).Value = this.Birthday;
                    command.Parameters.Add("@lvlID", SqlDbType.Int).Value = this.LevelID;
                    command.Parameters.Add("@desire", SqlDbType.NVarChar).Value = this.Desire;
                    command.Parameters.Add("@del", SqlDbType.TinyInt).Value = this.Del;
                    command.Parameters.Add("@remark", SqlDbType.NVarChar).Value = this.Remark;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
