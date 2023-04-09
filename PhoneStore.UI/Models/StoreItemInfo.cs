namespace PhoneStore.UI.Models
{
    public sealed record StoreItemInfo
    {
        public string Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string CategoryId { get; set; }

        public string Price { get; set; }

    public string? Description { get; set; } = string.Empty;

        public StoreItemInfo(string id, string name, string categoryId, string price, string description)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Price = price;
            Description = description;
        }
    }
}
