using DapperCrud.Dtos.ProductDtos;
using DapperCrud.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace DapperCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IProductService _service) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Add(AddProductDto model)
        {
            await _service.AddAsync(model);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductDto model)
        {
            await _service.UpdateAsync(model);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _service.GetAllProduct();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var values = await _service.GetProductByIdDto(id);
            return Ok(values);
        }
    }
}
