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
    class SkillManage:BaseModel
    {
        // Fields to be implemented by view.
        public int SkillListID;
        public DateTime startDate;
        public int Del;
        public string Remark;

        // SQL queries
        //
        // Get a list of ALL skills.
        public BindingList <SkillData> SkillList()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                BindingList<SkillData> list = new BindingList<SkillData>();
                string sql = "Execute SkillList";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SkillData skill = new SkillData()
                            {
                                SkillListID = reader.GetInt32(0),
                                SkillName = reader.GetString(1),
                                SkillType = reader.GetString(2),
                                Del = reader.GetByte(3),
                                Remark = reader.GetString(4)
                            };
                            list.Add(skill);
                        }
                    }
                }
                return list;
            }
        }
        
        // Get a list of skills based on UserID.
        public BindingList<SkillData> GetUserSkill(int ID)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                BindingList<SkillData> list = new BindingList<SkillData>();
                string sql = "Execute GetUserSkill @ID";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime time = new DateTime();
                            if (reader.IsDBNull(5))
                                time = DateTime.Now;
                            else time = reader.GetDateTime(5);
                            SkillData skill = new SkillData()
                            {
                                SkillListID = reader.GetInt32(0),
                                SkillName = reader.GetString(1),
                                SkillType = reader.GetString(2),
                                Del = reader.GetByte(3),
                                Remark = reader.GetString(4),
                                startDate = time
                            };
                            list.Add(skill);
                        }
                    }
                }
                return list;
            }
        }

        // Assign a new skill to the User.
        public void SkillAssign(int ID)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                int SkillID = Convert.ToInt32(ID.ToString() + SkillListID.ToString());
                string sql = "Execute AssignSkill @sID, @ID, @skillID, @start, @del, @remark";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@sID", SqlDbType.Int).Value = SkillID;
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    command.Parameters.Add("@skillID", SqlDbType.Int).Value = SkillListID;
                    command.Parameters.Add("@start", SqlDbType.Date).Value = startDate;
                    command.Parameters.Add("@del", SqlDbType.TinyInt).Value = Del;
                    command.Parameters.Add("@remark", SqlDbType.NVarChar).Value = Remark;
                    command.ExecuteNonQuery();
                }
            }
        }

        // Update a skill that's already assigned to a user.
        public void SaveSkillAssign(int ID)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                int SkillID = Convert.ToInt32(ID.ToString() + SkillListID.ToString());
                string sql = "Execute SaveSkillAssign @ID, @skillID, @start, @del, @remark,@sID";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@sID", SqlDbType.Int).Value = SkillID;
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    command.Parameters.Add("@skillID", SqlDbType.Int).Value = SkillListID;
                    command.Parameters.Add("@start", SqlDbType.Date).Value = startDate;
                    command.Parameters.Add("@del", SqlDbType.TinyInt).Value = Del;
                    command.Parameters.Add("@remark", SqlDbType.NVarChar).Value = Remark;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
