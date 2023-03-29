using PhoneStore.Api.DAL.Entities;

namespace PhoneStore.Api.DAL
{
    public interface IProductsRepository
    {
        public Task<IEnumerable<ProductEntity>> GetAllProducts();
        public Task<ProductEntity?> GetById(Guid id);

        public Task Create(ProductEntity entity);
    }
}
