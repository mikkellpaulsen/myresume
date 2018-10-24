using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Controllers;
using Model;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/me")]
    public class PersonController : Controller
    {
        PersonFacade personFacade = new PersonFacade();


        // GET: api/Person
        [HttpGet]
        public IActionResult GetPerson()
        {
            return Ok("you've reached Mikkel! leave a voicemail after the beep.");
        }

        // GET: api/me/id
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                //200
                return Ok(personFacade.GetPersonById(id));
            }
            catch
            {
                //500
                return NotFound("The server encountered an unexpected condition which prevented it from fulfilling the request.");
            }
        }

        // GET: api/projects
        [HttpGet("projects/{id}")]
        public IActionResult GetProjects(int id)
        {
            try
            {
                //200
                return Ok(personFacade.GetAllProjectsFromPerson(id));
            }
            catch
            {
                //500
                return NotFound("The server encountered an unexpected condition which prevented it from fulfilling the request.");
            }
        }

        // GET: api/jobs
        [HttpGet("jobs/{id}")]
        public IActionResult GetJobs(int id)
        {
            try
            {
                //200
                return Ok(personFacade.GetAllJobsFromPerson(id));
            }
            catch
            {
                //500
                return NotFound("The server encountered an unexpected condition which prevented it from fulfilling the request.");
            }
        }

        // GET: api/jobs
        [HttpGet("internships/{id}")]
        public IActionResult GetInternships(int id)
        {
            try
            {
                //200
                return Ok(personFacade.GetAllInternshipsFromPerson(id));
            }
            catch
            {
                //500
                return NotFound("The server encountered an unexpected condition which prevented it from fulfilling the request.");
            }
        }
         
    }
}
