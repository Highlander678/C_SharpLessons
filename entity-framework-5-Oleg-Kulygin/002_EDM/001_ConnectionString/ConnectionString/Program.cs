using System;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ConnectionString
{
    class Program
    {
        static void Main()
        {
            const string providerName = "System.Data.SqlClient";
            const string serverName = @"(LocalDB)\v11.0";
            string databasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+
                                    @"\App_Data\AdventureWorksLT2012_Data.mdf";

            // Initialize the connection string builder for the
            // underlying provider.
            var sqlBuilder = new SqlConnectionStringBuilder
                                 {
                                     DataSource = serverName,
                                     AttachDBFilename = databasePath,
                                     IntegratedSecurity = true
                                 };

            // Build the SqlConnection connection string.
            string providerString = sqlBuilder.ToString();

            // Initialize the EntityConnectionStringBuilder.
            var entityBuilder = new EntityConnectionStringBuilder
                {
                    Provider = providerName,
                    ProviderConnectionString = providerString,
                    Metadata = @"res://*/AdventureWorksLT2012.csdl|
                                       res://*/AdventureWorksLT2012.ssdl|
                                       res://*/AdventureWorksLT2012.msl"
                };

            Console.WriteLine(entityBuilder.ToString());

            using (var conn = new EntityConnection(entityBuilder.ToString()))
            {
                conn.Open();
                Console.WriteLine("Just testing the connection.");
                conn.Close();
            }

            Console.ReadKey();
        }
     
    }
}
