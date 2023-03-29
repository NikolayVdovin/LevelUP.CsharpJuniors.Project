using PhoneStore.Api.DAL.Entities;

namespace PhoneStore.Api.Models
{
    public sealed record ProductItem(Guid Id, string Name, Guid CategoryId, string? Descriptions) {
        public static ProductItem FromEntity(ProductEntity entity)
        {
            return new ProductItem(entity.Id, entity.Name, entity.CategoryId, entity.Description);
        }
    }
    
}
