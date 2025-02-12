namespace Best.Models
{
    public class BestModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? GitHub { get; set; }
        public string? LinkedIn { get; set; }
        public DateTime LastPurchase {  get; set; }
    }
}
