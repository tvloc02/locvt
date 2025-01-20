using BookPortal.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookPortal.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Book> Book { get; set; }
    }
}
