using PhoneStore.Api.DAL;
using PhoneStore.Api.DAL.Entities;
using PhoneStore.Api.Models;

namespace PhoneStore.Api.Services
{
    public sealed class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public async Task AddProduct(ProductItem productItem)
        {
            var productEntity = new ProductEntity
            {
                Id = productItem.Id,
                CategoryId = productItem.CategoryId,
                Name = productItem.Name,
                Description = productItem.Description,
                Price = productItem.Price
            };

            await _productsRepository.Create(productEntity);
        }

        public async Task<IEnumerable<ProductItem>> GetProducts()
        {
            var entities = await _productsRepository.GetAllProducts();
            return entities.Select(ProductItem.FromEntity);
        }

        public async Task<ProductItem?> GetProductsById(Guid productId)
        {
            var productEntity = await _productsRepository.GetById(productId);
            return productEntity == null ? null : ProductItem.FromEntity(productEntity);
        }

        public async Task DeleteProduct(Guid id)
        {
            await _productsRepository.Delete(id);
        }

        public async Task UpdateProduct(ProductItem productItem)
        {
            var productEntity = new ProductEntity
            {
                Id = productItem.Id,
                CategoryId = productItem.CategoryId,
                Name = productItem.Name,
                Description = productItem.Description,
                Price = productItem.Price
            };

            await _productsRepository.Update(productEntity);
        }
    }
}
