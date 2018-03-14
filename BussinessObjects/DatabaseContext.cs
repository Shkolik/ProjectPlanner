using Microsoft.EntityFrameworkCore;


namespace ProjectsPlanner.BussinessObjects
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ToDoTask> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Item> Items { get; set; }

        //public DatabaseContext()
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=projectplanner.db");
        }
    }
}
