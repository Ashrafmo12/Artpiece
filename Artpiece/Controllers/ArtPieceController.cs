using Artpiece.DTOs;
using Artpiece.Reposatory.ArtpieceRepo;
using Artpiece.Reposatory.CategoryRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Artpiece.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtPieceController : ControllerBase
    {
        private readonly IArtpiece _repo;
        public ArtPieceController(IArtpiece repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult Add(Arts arts)
        {
            _repo.Add(arts);
            return Created();
        }
        [HttpGet("GetAll")]
        public IActionResult Upadet()
        {
           var list= _repo.GetArts();
            return Ok(list);

        }
    }
}
