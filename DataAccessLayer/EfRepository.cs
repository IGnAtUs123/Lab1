using bus;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class EfRepository : IRepository<Student>
    {
        private readonly AppDbContext _context;

        public EfRepository(AppDbContext? context = null)
        {
            _context = context ?? new AppDbContext();
            // Создаст таблицу Students в .mdf, если её ещё нет
            _context.Database.EnsureCreated();
        }

        public void Create(Student entity)
        {
            _context.Students.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Student> ReadAll()
        {
            return _context.Students.AsNoTracking().ToList();
        }

        public Student? ReadById(string id)
        {
            // так как ключ строковый и HasKey(Id) задан — Find работает
            return _context.Students.Find(id);
        }

        public void Delete(string id)
        {
            var stud = _context.Students.Find(id);
            if (stud is null) return;

            _context.Students.Remove(stud);
            _context.SaveChanges();
        }

        public void Update(Student entity)
        {
            _context.Students.Update(entity);
            _context.SaveChanges();
        }
    }
}
