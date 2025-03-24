using Artpiece.DTOs;
using Artpiece.Reposatory.ArtpieceRepo;
using Artpiece.Reposatory.LoyaltyRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Artpiece.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LOyalryController : ControllerBase
    {
        private readonly ILoyalty _repo;
        public LOyalryController(ILoyalty repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult Add(Loyalty lo)
        {
            _repo.Add(lo);
            return Created();
        }
        [HttpDelete]
        public IActionResult delete(int id)
        {
            _repo.Delete(id);
            return NoContent();

        }
    }
}
