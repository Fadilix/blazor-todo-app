using Microsoft.EntityFrameworkCore;

namespace BlazorTodoApp.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public void OnModelCreating()
        {

        }
        //public DbSet<Todo> Todos { get; set; }
    }
}
