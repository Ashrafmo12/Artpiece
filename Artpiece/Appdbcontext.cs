using Microsoft.EntityFrameworkCore;
using Artpiece.Models;

namespace Artpiece
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Artpiecee> Artpieces    { get; set; }
        public DbSet<LoyaltyCard> LoyaltyCards { get; set; }
        public DbSet<Customer> Customer { get; set; }   
        public DbSet<Category> Category { get; set; }

    }
}
