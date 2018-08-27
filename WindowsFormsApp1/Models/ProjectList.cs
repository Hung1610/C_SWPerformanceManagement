using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class ProjectList
    {
        // Connect to the table then establish connection.
        SQLConnect cn = new SQLConnect();

        // Write the query and execute.
        
        public List<string> genList()
        {
            SqlConnection conn = cn.Connect();
            List<string> list= new List<string>();
            conn.Open();
            string sql = "select [ProjectName] " +
                "from [200TB_Project] ";
            Console.WriteLine(sql);
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }
            }
            conn.Close();
            return list;
        }
    }
}
