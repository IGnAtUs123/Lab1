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
      AttachDbFilename=|DataDirectory|\Students.mdf;
      Integrated Security=True;
      Connect Timeout=30");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Явно укажем первичный ключ — строковое поле Id
            modelBuilder.Entity<Student>().HasKey(s => s.Id);

            // Дополнительные ограничения (по желанию)
            modelBuilder.Entity<Student>().Property(s => s.Name).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Student>().Property(s => s.Speciality).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Student>().Property(s => s.Group).IsRequired().HasMaxLength(50);
        }
    }
}
