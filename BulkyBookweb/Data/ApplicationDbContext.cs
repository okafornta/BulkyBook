using BulkyBookweb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookweb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> categories { get; set; }
        public IEnumerable<Category> Categories { get; internal set; }
    }
}
