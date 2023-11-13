namespace My_Portfolio.Models
{
    public class PortfolioItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProjectUrl { get; set; } 
        public string GitHubRepository { get; set; } 
        public List<string> TechnologiesUsed { get; set; } 
        public DateTime DateCompleted { get; set; }
    }
}
