using PhoneStore.Api.Models;

namespace PhoneStore.Api.Services
{
    public interface IProductsService
    {
        Task<IEnumerable<ProductItem>> GetProducts();
        Task<ProductItem?> GetProductsById(Guid guid);
        Task AddProduct(ProductItem productItem);
        Task UpdateProduct(ProductItem productItem);
        Task DeleteProduct(Guid id);
    }
}
