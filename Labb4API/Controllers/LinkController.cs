using Labb4API.Models;
using Labb4API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : ControllerBase
    {
        private ILinks<Link> _LinkRepo;

        public LinkController(ILinks<Link> linksRepo)
        {
            _LinkRepo = linksRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllLinksFromOnePerson(int id)
        {
            try
            {
                return Ok(await _LinkRepo.AllLinksFromOnePerson(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Faild to get data from database");
            }

        }
        
        [HttpPost]
        public async Task<ActionResult> AddLink(Link newLink)
        {
            try
            {
                if (newLink == null)
                {
                    return BadRequest();
                }

                var result = await _LinkRepo.NewLink(newLink);

                return CreatedAtAction(nameof(GetAllLinksFromOnePerson), new { id = result.LinksId }, result);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
