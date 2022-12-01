using BooksDemoRazor.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BooksDemoRazor.Data.Access
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)  : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

    }
}
