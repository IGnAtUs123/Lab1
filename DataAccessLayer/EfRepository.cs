using bus;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

public class EfRepository : IRepository<Student>
{
    private readonly AppDbContext _context;

    public EfRepository(AppDbContext context)
    {
        _context = context;
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

    public Student ReadById(string id)
    {
        return _context.Students.AsNoTracking().FirstOrDefault(s => s.Id == id);
    }

    public void Update(Student entity)
    {
        _context.Students.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(string id)
    {
        var st = _context.Students.FirstOrDefault(s => s.Id == id);
        if (st != null)
        {
            _context.Students.Remove(st);
            _context.SaveChanges();
        }
    }
}
