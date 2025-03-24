using Artpiece.DTOs;
using Artpiece.Models;

namespace Artpiece.Reposatory.CustomerRepo
{
    public interface ICustomer
    {
        public void Add(AddCustomer addCustomer);
        public IList<Customer> GetAll();
        public void Update(AddCustomer updateCustomer,int id);
    }
}
