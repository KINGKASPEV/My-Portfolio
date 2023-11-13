using Microsoft.EntityFrameworkCore;
using My_Portfolio.Models;

namespace MyPortfolio.Data
{
    public class MyPortfolioDbContext : DbContext
    {
        public MyPortfolioDbContext(DbContextOptions<MyPortfolioDbContext> options) : base(options)
        {
        }

        public DbSet<PortfolioItem> portfolioItems { get; set; }
    }
}
