using API_Intro_HomeTask.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Intro_HomeTask.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categpries { get; set; }
        public DbSet<Book> Books { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                { Id = 1,
                CreatedDate = DateTime.Now,
                Name = "UI UX",
                },
                new Category
                { Id = 2,
                CreatedDate = DateTime.Now,
                Name = "Backend",
                },
                new Category
                {
                   Id = 3,
                   CreatedDate = DateTime.Now,
                   Name = "Frontend",
                   
                 });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    Name = "Harry Potter",
                    Price = 121
                },
                new Book
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    Name = "Don Quixote",
                    Price = 140
                },
                new Book
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    Name = "In Search of Lost Time",
                    Price = 180
                });




            


            base.OnModelCreating(modelBuilder);
        }
    }
}
