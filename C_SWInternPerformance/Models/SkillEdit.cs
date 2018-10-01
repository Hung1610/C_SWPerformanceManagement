using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Models
{
    class SkillEdit:BaseModel
    {
        // Fields to be implemented by view.
        public int SkillEditID;
        public string SkillName;
        public string SkillType;
        public int DelEdit;
        public string RemarkEdit;

        // SQL Queries.
        //
        // Add a new skill.
        public void AddSkill()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "Execute AddSkill @sID, @name, @type, @del, @remark";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@sID", SqlDbType.Int).Value = SkillEditID;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = SkillName;
                    command.Parameters.Add("@type", SqlDbType.NVarChar).Value = SkillType;
                    command.Parameters.Add("@del", SqlDbType.TinyInt).Value = DelEdit;
                    command.Parameters.Add("@remark", SqlDbType.NVarChar).Value = RemarkEdit;
                    command.ExecuteNonQuery();
                }
            }
        }
        // Save skill info.
        public void SaveSkill()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string sql = "Execute SaveSkill @name, @type, @del, @remark, @editID";
                Console.WriteLine(sql);
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = SkillName;
                    command.Parameters.Add("@type", SqlDbType.NVarChar).Value = SkillType;
                    command.Parameters.Add("@del", SqlDbType.TinyInt).Value = DelEdit;
                    command.Parameters.Add("@remark", SqlDbType.NVarChar).Value = RemarkEdit;
                    command.Parameters.Add("@editID", SqlDbType.Int).Value = SkillEditID;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
