using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISAPP.assessment.Util
{

    public static class DBConnUtil
    {
        // Method to return a SqlConnection using appsettings.json
        public static SqlConnection GetConnection()
        {
            // Build the configuration object to read appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Read the connection string named "CrimeDB"
            string connectionString = config.GetConnectionString("SISDB");

            // Return a new SqlConnection
            return new SqlConnection(connectionString);
        }
    }
}
