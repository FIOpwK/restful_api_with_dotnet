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
        [HttpPost]
        public IActionResult Create(Issue issue)
        {
            // this code will add/create a new issue
            IssueService.Add(issue);
            return CreatedAtAction(nameof(Create), new {id = issue.Id}, issue);
        }

        // PUT action
        [HttpPut("{id")]
        public IActionResult Update(int id, Issue issue)
        {
            // this code will update an issue and return a result
            if (id != issue.Id)
                return BadRequest();

            var existingIssue = IssueService.Get(id);
            if (existingIssue is null)
                return NotFound();

            IssueService.Update(issue);

            return NoContent();
        }


        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // this code will delete the issue and return a result
        }
    }
}