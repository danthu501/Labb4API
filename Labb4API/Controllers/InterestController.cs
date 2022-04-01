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
    public class InterestController : ControllerBase
    {
        private IInterestRepository<Interest> _InterestRepo;
        public InterestController(IInterestRepository<Interest> labb4API)
        {
            _InterestRepo = labb4API;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllIntresetsFromOnePerson(int id)
        {
            try
            {
                return Ok(await _InterestRepo.GetAllInterestsFromPerson(id));
            }
            catch (Exception)
            {

                return NotFound("There is no person with that id that have any interests");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddNewInterest(Interest newInterest)
        {
            try
            {
                if (newInterest == null)
                {
                    return BadRequest();
                }

                var result = await _InterestRepo.NewInterest(newInterest);

                return CreatedAtAction(nameof(GetAllIntresetsFromOnePerson), new { id = result.IntrestId}, result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Unable to create data on database");
            }
        }
    }
}
