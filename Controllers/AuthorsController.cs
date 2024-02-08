
using System.Collections.Generic;
using System.Threading.Tasks;
using app_leaky.Models;
using app_leaky.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace app_leaky.Controllers
{
    [Route("api/[controller]")]
    public class AuthorsController : Controller
    {
        private readonly IAuthorsRepository _authorsRepository;
        
        public AuthorsController(IAuthorsRepository authorsRepository)
        {
            _authorsRepository = authorsRepository;
        }
        
        // POST api/values
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]string name)
        {
            var result = await _authorsRepository.AddAuthor(name);

            if (result.ResponseCode != 0)
            {
                return BadRequest(result.Message);
            }

            return Ok();
        }
    }
}