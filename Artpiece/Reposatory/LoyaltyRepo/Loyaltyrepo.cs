using Artpiece.DTOs;
using Artpiece.Models;

namespace Artpiece.Reposatory.LoyaltyRepo
{
    public class Loyaltyrepo : ILoyalty
    {
        private readonly Appdbcontext _context;
        public Loyaltyrepo(Appdbcontext context)
        {
            _context = context;
        }
        public void Add(Loyalty loyalty)
        {
            var loya=new LoyaltyCard()
            {
                 Balance=loyalty.Balance,
            };
            _context.LoyaltyCards.Add(loya);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var loya=_context.LoyaltyCards.FirstOrDefault(x => x.Id==id);
            if (loya != null)
            {
                _context.LoyaltyCards.Remove(loya);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Not found");
            }
        }
    }
}
