using System.Collections.Generic;
using bus;

namespace Model
{
    public interface IModel
    {
        void AddStudent(string id, string name, string speciality, string group);
        void DeleteStudent(string id);
        IEnumerable<Student> GetAll();
    }
}
