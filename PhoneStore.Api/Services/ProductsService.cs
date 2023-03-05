using PhoneStore.Api.Models;

namespace PhoneStore.Api.Services
{
    public sealed class ProductsService : IProductsService
    {
        private Dictionary<Guid, ProductItem> _products = new();
        public ProductsService()
        {
            InitProducts();
        }

        private void InitProducts()
        {
            var guid1 = Guid.NewGuid();
            var guid2 = Guid.NewGuid();
            var guid3 = Guid.NewGuid();

            _products = new Dictionary<Guid, ProductItem>
            {
                {guid1, new ProductItem(guid1, "Nokia", "") },
                {guid2, new ProductItem(guid2, "Samsung", "Корейский смартфон") },
                {guid3, new ProductItem(guid3, "Honor", "") },

            };

        }

        public IEnumerable<ProductItem> GetProducts()
        {
            return _products.Values;
        } 
        public IEnumerable<ProductItem> GetProductsById(Guid guid)
        {
             _products.TryGetValue(guid, out var item);

            yield return item;
        }
    }
}
