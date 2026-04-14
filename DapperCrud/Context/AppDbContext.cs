using Microsoft.Data.SqlClient;
using System.Data;

namespace DapperCrud.Context
{
    public class AppDbContext 
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection")
                                ?? throw new InvalidOperationException("Bağlantı dizesi bulunamadı.");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
