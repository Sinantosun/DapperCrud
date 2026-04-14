using Dapper;
using DapperCrud.Context;
using DapperCrud.Dtos.ProductDtos;

namespace DapperCrud.Services.ProductServices
{
    public class ProductService(AppDbContext _context) : IProductService
    {
        public async Task AddAsync(AddProductDto product)
        {
            using var connection = _context.CreateConnection();
            var sql = "INSERT INTO Products (Name, Price, Stock) VALUES (@Name, @Price, @Stock)";
            var parametres = new DynamicParameters();
            parametres.Add("@Name", product.Name);
            parametres.Add("@Price", product.Price);
            parametres.Add("@Stock", product.Stock);
            await connection.ExecuteAsync(sql, parametres);
        }

        public async Task DeleteAsync(int id)
        {
            using var connection = _context.CreateConnection();
            var sql = "DELETE FROM Products WHERE Id = @Id";
            var parametres = new DynamicParameters();
            parametres.Add("@Id", id);
            await connection.ExecuteAsync(sql, parametres);
        }

        public async Task<IEnumerable<ResultProductDto>> GetAllProduct()
        {
            var sql = "SELECT * FROM Products";
            using var connection = _context.CreateConnection();
            return await connection.QueryAsync<ResultProductDto>(sql);
        }

        public async Task<ResultProductByIdDto> GetProductByIdDto(int id)
        {
            var sql = "SELECT * FROM Products WHERE Id = @Id";
            using var connection = _context.CreateConnection();
            var parametres = new DynamicParameters();
            parametres.Add("@Id", id);
            return await connection.QueryFirstAsync<ResultProductByIdDto>(sql, parametres);
        }

        public async Task UpdateAsync(UpdateProductDto product)
        {
            using var connection = _context.CreateConnection();
            var sql = "UPDATE Products SET Name = @Name, Price = @Price, Stock = @Stock WHERE Id = @Id";
            var parametres = new DynamicParameters();
            parametres.Add("@Name", product.Name);
            parametres.Add("@Price", product.Price);
            parametres.Add("@Stock", product.Stock);
            parametres.Add("@Id", product.Id);
            await connection.ExecuteAsync(sql, parametres);
        }
    }
}
