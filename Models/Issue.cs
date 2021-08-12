namespace IssueTracker.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Reporter { get; set; }
        public bool IsOpen { get; set; }
        public bool IsAssigned {get; set;}
        public string Description {get; set;}
        public string Status {get; set;}
        public string Summary {get; set;}

    }
}