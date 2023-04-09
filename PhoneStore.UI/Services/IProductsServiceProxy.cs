using PhoneStore.UI.Models;

namespace PhoneStore.UI.Services
{
    public interface IProductsServiceProxy
    {
        Task<IEnumerable<ProductItem>> GetAllProducts();
        Task<ProductItem> GetProductById(Guid id);
        Task CreateProduct(ProductItem productItem);
        Task UpdateProduct(ProductItem productItem);
        Task DeleteProduct(Guid id);
    }
}
