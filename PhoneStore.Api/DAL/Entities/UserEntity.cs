namespace PhoneStore.Api.DAL.Entities
{
    public sealed record UserEntity
    {
       public Guid Id { get; init; }
       public String Name { get; init; } = string.Empty;
       public bool IsAdmin { get; init; }
    }
}
