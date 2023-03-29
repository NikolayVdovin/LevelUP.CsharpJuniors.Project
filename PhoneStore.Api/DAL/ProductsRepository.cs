using PhoneStore.Api.DAL.Entities;
using System.Data.Entity;

namespace PhoneStore.Api.DAL
{
    public sealed class ProductsRepository : IProductsRepository
    {
        private readonly ProductsDbContext _dbContext;
        public ProductsRepository(ProductsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<IEnumerable<ProductEntity>> GetAllProducts()
        {
            return Task.FromResult<IEnumerable<ProductEntity>>(_dbContext.Products!.ToList());
        }
        public async Task<ProductEntity?> GetById(Guid id)
        {
            var entity = await _dbContext.Products!
                .FirstOrDefaultAsync(e => e.Id.Equals(id));

            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Create(ProductEntity entity)
        {
            await _dbContext.Products!.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
