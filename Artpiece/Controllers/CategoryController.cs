using Artpiece.DTOs;
using Artpiece.Reposatory.CategoryRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Artpiece.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly Icategory _repo;
        public CategoryController(Icategory repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult Add(Addcategory addcategory)
        {
            _repo.Add(addcategory);
            return Created();
        }
        [HttpPut]
        public IActionResult Upadet(Addcategory addcategory, int id)
        {
            _repo.Update(addcategory, id);
            return Ok();

        }
    }
}
