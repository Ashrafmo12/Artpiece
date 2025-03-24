namespace Artpiece.Models
{
    public class LoyaltyCard
    {
        public int Id { get; set; }
        public int? Balance { get; set; }
        public IList<Artpiecee>? artpieces { get; set; }
    }
}
