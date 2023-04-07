using Microsoft.AspNetCore.Mvc;
using PhoneStore.Api.Models;
using PhoneStore.Api.Services;

namespace PhoneStore.Api.Controllers
{
    [ApiController]
    [Route ("products")]
    public sealed class ProductsController : ControllerBase
    {
        private IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<ProductItem>>> GetProducts()
        {
            var products = await _productsService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ProductItem>> GetProductsById(Guid productId) 
        {
            var products =  await _productsService.GetProductsById(productId);
            return products == null ? NotFound("Нет смартфона с таким ID") : Ok(products);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddProduct(ProductItem productItem)
        {
            await _productsService.AddProduct(productItem);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateProduct(ProductItem product)
        {
            await _productsService.UpdateProduct(product);
            return Ok(product);
        }

        [HttpDelete("delete")]
        public async Task<ActionResult> DeleteProduct(Guid id)
        {
            await _productsService.DeleteProduct(id);
            return Ok();
        }
    }
}
