    using BlazorTodoApp.Models;
    using Microsoft.EntityFrameworkCore;

    namespace BlazorTodoApp.Context
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
     
            }

            public DbSet<Todo> Todos { get; set; }
        }
    }
