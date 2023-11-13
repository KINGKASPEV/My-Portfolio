using My_Portfolio.Data.Repositories.Interface;
using My_Portfolio.Models;

namespace My_Portfolio.Data.Repositories.Implementations
{
    public class PortfolioRepository : IPortfolioRepository
    {
        public List<PortfolioItem> GetPortfolioItems()
        {
            return new List<PortfolioItem>
            {
                new PortfolioItem
                {
                    Title = "Project 1",
                    Description = "Description of Project 1",
                    ProjectUrl = "https://project1.com",
                    GitHubRepository = "https://github.com/project1",
                    TechnologiesUsed = new List<string> { "ASP.NET Core", "React", "MongoDB" },
                    DateCompleted = new DateTime(2022, 5, 15)
                },
            };
        }
    }
}
