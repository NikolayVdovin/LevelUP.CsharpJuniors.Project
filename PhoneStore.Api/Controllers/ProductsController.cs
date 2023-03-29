using Microsoft.AspNetCore.Mvc;
using PhoneStore.Api.Models;
using PhoneStore.Api.Services;

namespace PhoneStore.Api.Controllers
{
    [ApiController]
    [Route ("ProductsController")]
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
            return products == null ? NotFound("Нет продукта по данному Id") : Ok(products);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddProduct(ProductItem productItem)
        {
            await _productsService.AddProduct(productItem);
            return Ok();
        }
    }
}
