using IssueTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace IssueTracker.Services
{
    public static class IssueService
    {
        static List<Issue> Issues { get; }
        static int nextId = 3;
        static IssueService()
        {
            Issues = new List<Issue>
            {
                new Issue { Id = 1, Reporter = "Classic Italian", IsAssigned = false, Description = "Test", Status = "In-review" },
                new Issue { Id = 2, Reporter = "Veggie", IsAssigned = true, Description = "Tests", Status = "In-review" }
            };
        }

        public static List<Issue> GetAll() => Issues;

        public static Issue Get(int id) => Issues.FirstOrDefault(p => p.Id == id);

        public static void Add(Issue Issue)
        {
            Issue.Id = nextId++;
            Issues.Add(Issue);
        }

        public static void Delete(int id)
        {
            var Issue = Get(id);
            if(Issue is null)
                return;

            Issues.Remove(Issue);
        }

        public static void Update(Issue Issue)
        {
            var index = Issues.FindIndex(p => p.Id == Issue.Id);
            if(index == -1)
                return;

            Issues[index] = Issue;
        }
    }
}