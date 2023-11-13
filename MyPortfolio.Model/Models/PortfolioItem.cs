using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Portfolio.Models
{
    [Table("PortfolioItem")]
    public class PortfolioItem
    {
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProjectUrl { get; set; } 
        public string GitHubRepository { get; set; } 
        public List<string> TechnologiesUsed { get; set; } 
        public DateTime DateCompleted { get; set; }
    }
}
