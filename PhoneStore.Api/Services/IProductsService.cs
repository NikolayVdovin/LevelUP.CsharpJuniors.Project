using PhoneStore.Api.Models;

namespace PhoneStore.Api.Services
{
    public interface IProductsService
    {
        IEnumerable<ProductItem> GetProducts();
        IEnumerable<ProductItem> GetProductsById(Guid guid);
    }
}
