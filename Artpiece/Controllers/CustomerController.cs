using Artpiece.DTOs;
using Artpiece.Reposatory.CustomerRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Artpiece.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer _repo;
        public CustomerController(ICustomer repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var list = _repo.GetAll();
            return Ok(list);
        }
        [HttpPost]
        public IActionResult Add(AddCustomer addCustomer)
        {
            _repo.Add(addCustomer);
            return Created();
        }
        [HttpPut]
        public IActionResult Update(AddCustomer add,int id)
        {
            _repo.Update(add, id);
            return Ok();
        }

    }
}
