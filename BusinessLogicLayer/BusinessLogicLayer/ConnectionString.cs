using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    class ConnectionString
    {
        public SqlConnection GetConnection()
        {
            string connectionString = "Data Source=SOAIB;Initial Catalog=HBS;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
