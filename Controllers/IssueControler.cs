using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using IssueTracker.Models;
using IssueTracker.Services;

namespace IssueTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IssueController : ControllerBase
    {
        public IssueController()
        {
        }

        // GET all action
        [HttpGet]
        public ActionResult<List<Issue>> GetAll() => IssueService.GetAll();

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Issue> Get(int id)
        {
            var issue = IssueService.Get(id);

            if(issue == null)
                return NotFound();

            return issue;
        }

        // POST action

        // PUT action

        // DELETE action
    }
}