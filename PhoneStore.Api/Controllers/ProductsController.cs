using Microsoft.AspNetCore.Mvc;
using PhoneStore.Api.Models;
using PhoneStore.Api.Services;

namespace PhoneStore.Api.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public sealed class ProductsController : ControllerBase
    {
        private IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet("all")]
        public ActionResult<IEnumerable<ProductItem>> GetProducts()
        {
            var products = _productsService.GetProducts();
            return Ok(products);
        }

        [HttpGet("by Id")]
        public ActionResult<IEnumerable<ProductItem>> GetProductsById(Guid guid) 
        {
            var products = _productsService.GetProductsById(guid);
            return Ok(products);
        }
    }
}
