using bus;
using DataAccessLayer;
using System.Collections.Generic;

namespace Logic
{
    public class BusinessLogic
    {
        public IRepository<Student> Repository { get; }

        public BusinessLogic(IRepository<Student> repository)
        {
            Repository = repository;
        }

        public void AddStudent(string id, string name, string speciality, string group)
        {
            var student = new Student { Id = id, Name = name, Speciality = speciality, Group = group };
            Repository.Create(student);
        }

        public IEnumerable<Student> ShowTheListOfStudents()
        {
            return Repository.ReadAll();
        }

        public void UpdateStudent(Student s) => Repository.Update(s);
        public void DeleteStudent(string id) => Repository.Delete(id);

        public IEnumerable<Student> ShowTheHistogram()
        {
            return Repository.ReadAll();
        }
    }
}
