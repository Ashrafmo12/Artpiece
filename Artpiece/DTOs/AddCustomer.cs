namespace Artpiece.DTOs
{
    public class AddCustomer
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public IList<Arts>? Arts { get; set; }
    }
}
