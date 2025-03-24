using Artpiece.DTOs;
using Artpiece.Models;

namespace Artpiece.Reposatory.CustomerRepo
{
    public class Customerrepo : ICustomer
    {
        private readonly Appdbcontext _context;
        public Customerrepo(Appdbcontext context)
        {
            _context = context;
        }
        public void Add(AddCustomer addCustomer)
        {
            var customer = new Customer
            {
                 Name = addCustomer.Name,
                 Email = addCustomer.Email,
                 Artists=addCustomer.Arts.Select(p=> new Artpiecee
                 {
                     Title = p.Title,
                     Price = p.Price,
                     Description=p.Description,
                 }).ToList(),
                 
            };
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }

        public IList<Customer> GetAll()
        {
           var list =_context.Customer.ToList();
            return list;
        }

        public void Update(AddCustomer updateCustomer, int id)
        {
            var customer=_context.Customer.FirstOrDefault(p => p.Id == id);
            if (customer == null)
            {
                throw new Exception
                    ("The Customer not Found ");
            }
            else
            {
                customer.Name = updateCustomer.Name;    
                customer.Email = updateCustomer.Email;
            }
        }
    }
}
