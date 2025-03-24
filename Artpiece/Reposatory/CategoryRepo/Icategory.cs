using Artpiece.DTOs;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace Artpiece.Reposatory.CategoryRepo
{
    public interface Icategory
    {
        public void Add(Addcategory addcategory);
        public void Update(Addcategory addcategory, int id);
    }
}
