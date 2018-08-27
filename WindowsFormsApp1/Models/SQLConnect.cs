using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class SQLConnect
    {

        public SqlConnection Connect()
        {
            // Build connection string
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "DESKTOP-G8FN8CR\\SQLEXPRESS",   // update me
                UserID = "sa",              // update me
                Password = "123",      // update me
                InitialCatalog = "SW_PerformanceManagement"
            };

            // Connect to SQL
            Console.Write("Connecting to SQL Server ... ");
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            Console.WriteLine("Done.");
            return connection;
        }
    }
}
