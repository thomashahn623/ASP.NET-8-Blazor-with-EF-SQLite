using Microsoft.EntityFrameworkCore;

namespace MeinBlazorProjekt.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // EF Model for Todo Item
        // -----------------------------------------------------------------------
        public DbSet<Models.TodoItem> TodoItems { get; set; }

    }
}