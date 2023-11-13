using Microsoft.AspNetCore.Mvc;
using My_Portfolio.Models;

namespace My_Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            var portfolioItems = GetPortfolioItems();

            return View(portfolioItems);
        }

        private List<PortfolioItem> GetPortfolioItems()
        {
            // This is just an example, replace it with actual data retrieval logic
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
