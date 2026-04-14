using DapperCrud.Dtos.ProductDtos;

namespace DapperCrud.Services.ProductServices
{
    public interface IProductService
    {
        Task AddAsync(AddProductDto product);
        Task UpdateAsync(UpdateProductDto product);
        Task DeleteAsync(int id);   
        Task<ResultProductByIdDto> GetProductByIdDto(int id);
        Task<IEnumerable<ResultProductDto>> GetAllProduct();
    }
}
