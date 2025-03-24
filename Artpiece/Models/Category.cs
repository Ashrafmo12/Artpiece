namespace Artpiece.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IList<Artpiecee>? Artists { get; set; }

    }
}
