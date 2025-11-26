using Microsoft.EntityFrameworkCore;
using bus;
using System.IO;

namespace DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;
              Initial Catalog=Students;
              Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(s => s.Id);

            modelBuilder.Entity<Student>().Property(s => s.Name).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Student>().Property(s => s.Speciality).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Student>().Property(s => s.Group).IsRequired().HasMaxLength(50);
        }
    }
}
