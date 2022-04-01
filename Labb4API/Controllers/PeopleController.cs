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
    public class PeopleController : ControllerBase
    {
        private ILabb4API<People> _labb4API { get; set; }

        public PeopleController(ILabb4API<People> labb4API)
        {
            _labb4API = labb4API;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPepole()
        {
            try
            {
                return Ok(await _labb4API.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Unable to retrive data from database");
            }
        }
    }
}
