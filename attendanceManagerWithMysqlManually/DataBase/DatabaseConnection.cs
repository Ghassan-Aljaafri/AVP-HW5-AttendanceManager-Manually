using System.Configuration;
using System.Data.Common;
using MySql.Data.MySqlClient;


namespace attendanceManagerWithMysqlManually.DataBase
{
    class DatabaseConnection
    {
        // Caches the connection string
        private static string DbConnectionString;
        // Caches the data provider name 
        private static string DbProviderName;

        static DatabaseConnection()
        {
            DbConnectionString = ConfigurationManager.ConnectionStrings["AppconnectionStrings"].ConnectionString;
        }

        public static MySqlConnection getConnection()
        {
            string connectionString = DbConnectionString;
            return new MySqlConnection(connectionString);
        }
    }
}
