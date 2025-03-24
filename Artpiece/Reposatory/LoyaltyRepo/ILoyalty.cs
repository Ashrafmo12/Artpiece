using Artpiece.DTOs;

namespace Artpiece.Reposatory.LoyaltyRepo
{
    public interface ILoyalty
    {
        public void Add(Loyalty loyalty);
        public void Delete(int id);
    }
}
