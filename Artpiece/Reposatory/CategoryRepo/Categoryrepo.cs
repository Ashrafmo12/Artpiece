using Artpiece.DTOs;
using Artpiece.Models;

namespace Artpiece.Reposatory.CategoryRepo
{
    public class Categoryrepo : Icategory
    {
        private readonly Appdbcontext _context;
        public Categoryrepo(Appdbcontext context)
        {
            _context = context;
        }
        public void Add(Addcategory addcategory)
        {
            var category = new Category
            {
              Name = addcategory.Name,  
            };

        }

        public void Update(Addcategory addcategory, int id)
        {
            var category=_context.Category.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                category.Name = addcategory.Name;
               
            }
            else
            {
                throw new Exception("The Category not found");
            }
        }
    }
}
