namespace Artpiece.Models
{
    public class Artpiecee
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public int? loyalityId { get; set; }
        public LoyaltyCard? LoyaltyCard { get; set; }

    }
}
