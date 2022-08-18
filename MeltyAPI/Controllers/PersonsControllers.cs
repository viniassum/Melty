using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeltyAPI.Models;
using MeltyAPI.Services;
using System.Web;

namespace MeltyAPI.Controllers
{
    [ApiController]
    [Route("Persons")]
    public class PersonsControllers : Controller
    {
        private readonly ILogger<PersonsControllers> logger;
        private readonly IPersonService person;

        public PersonsControllers(ILogger<PersonsControllers> _logger, IPersonService _person)
        {
            logger = _logger;
            person = _person;
        }

        [HttpGet]
        [Produces("application/json")]
        public ActionResult Get()
        {
            return Ok(person.Get());
        }

        [HttpGet]
        [Route("GetById/{id}")]
        [Produces("application/json")]
        public ActionResult GetById(int id)
        {
            return Ok(person.GetById(id));
        }

        [HttpPost]
        [Route("Save/{id}")]
        [Produces("application/json")]
        public ActionResult Save(int id, string firstName, string lastName)
        {
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                return Ok(person.Save(id, firstName, lastName));
            }
            else
            {
                return BadRequest("First Name and Last Name are required");
            }
        }
    }
}
