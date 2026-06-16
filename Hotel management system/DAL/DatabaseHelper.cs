using System.Configuration;
using System.Data.SqlClient;

namespace Hotel_management_system.DAL
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static string ConnectionString => connectionString;
    }
}