using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Model
{
    public class InMemoryModel : IModel
    {
        private readonly List<Student> _students = new List<Student>();

        public void AddStudent(string id, string name, string speciality, string group)
        {
            if (_students.Any(s => s.Id == id)) return;

            _students.Add(new Student
            {
                Id = id,
                Name = name,
                Speciality = speciality,
                Group = group
            });
        }

        public void DeleteStudent(string id)
        {
            var s = _students.FirstOrDefault(x => x.Id == id);
            if (s != null) _students.Remove(s);
        }

        public IEnumerable<Student> GetAll() => _students.ToList();
    }
}
