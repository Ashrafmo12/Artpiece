using Artpiece.DTOs;
using Artpiece.Models;
using Microsoft.EntityFrameworkCore;

namespace Artpiece.Reposatory.ArtpieceRepo
{
    public class Artpiecerepo : IArtpiece
    {
        private readonly Appdbcontext _context;
        public Artpiecerepo(Appdbcontext context)
        {
            _context = context;
        }
        public void Add(Arts arts)
        {
            var art = new Artpiecee
            {
                Title = arts.Title,
                Price = arts.Price,
                Description = arts.Description,
                Category = new Category
                {
                    Name = arts.Category
                },
                Customer=new Customer
                {
                    Name=arts.customer.Name,
                    Email=arts.customer.Email,

                },
                LoyaltyCard=new LoyaltyCard
                {
                    Balance=arts.Loyalty
                }
                
                
                

            };
            _context.Artpieces.Add(art);
            _context.SaveChanges();
        }

        public IList<Arts> GetArts()
        {
            var artPieces = _context.Artpieces.AsNoTracking().ToList();

            var artsList = artPieces.Select(artPiece => new Arts
            {
                Title = artPiece.Title,
                Price = artPiece.Price,
                Description = artPiece.Description,
            }).ToList();

            return artsList;
        }
    }
}
