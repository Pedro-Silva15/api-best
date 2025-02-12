using Best.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Best.Data
{
    public class BestRepository
    {
        private string _connectionString;

        public BestRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public BestModel GetBest()
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.QueryFirst<BestModel>("SELECT TOP 1 [id] AS Id, [first_name] AS FirstName, [last_name] AS LastName, [description] AS Description, [github] AS GitHub, [linkedin] AS LinkedIn, [last_purchase] AS LastPurchase FROM best ORDER BY [last_purchase] DESC;");
        }
    }
}
