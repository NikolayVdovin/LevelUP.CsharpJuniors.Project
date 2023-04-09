using Microsoft.EntityFrameworkCore;
using PhoneStore.Api.DAL.Entities;

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

        public async Task Update(ProductEntity entity)
        {
            _dbContext.Products!.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var entity = await _dbContext.Products!
               .FirstOrDefaultAsync(e => e.Id.Equals(id));

            _ = _dbContext.Products!.Remove(entity);

            await _dbContext.SaveChangesAsync();
        }
    }
}
