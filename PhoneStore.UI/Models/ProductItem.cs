namespace PhoneStore.UI.Models
{
    public sealed record ProductItem(Guid Id, string Name, Guid CategoryId, decimal Price, string? Description);    
}
