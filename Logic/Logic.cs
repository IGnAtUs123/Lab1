namespace Logic
{
    using bus;
    using System.ComponentModel;

    public class Logic
    {
        private List<Student> students = new List<Student>();
        public void AddStudent(string name, string speciality, string group, string id) 
        {
            if (!students.Contains(new Student { Id = id }))
            {
                students.Add(new Student { Name = name, Speciality = speciality, Group = group, Id = id });
            }
        }
        public void DeleteStudent(string id)
        {
            students.RemoveAll(item => item.Id == id);
        }
        public List<Student> ShowTheListOfStudents ()
        {
            return students;
        }
        public List<Student> ShowTheHistogram()
        {
            return students.OrderBy(x => x.Speciality).ToList();
        }
    }
}
