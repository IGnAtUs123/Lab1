namespace Logic
{
    using bus;
    using DataAccessLayer;

    public class Logic
    {
        private readonly IRepository<Student> _repository;

        public Logic(IRepository<Student> repository)
        {
            _repository = repository;
        }

        public void AddStudent(string name, string speciality, string group, string id)
        {
            if (_repository.ReadById(id) != null)
            {
                // уже есть студент с таким Id — ничего не делаем
                return;
            }

            var student = new Student
            {
                Id = id,
                Name = name,
                Speciality = speciality,
                Group = group
            };
            _repository.Create(student);
        }

        public void DeleteStudent(string id)
        {
            _repository.Delete(id);
        }

        public List<Student> ShowTheListOfStudents()
        {
            return _repository.ReadAll().ToList();
        }

        public List<Student> ShowTheHistogram()
        {
            return _repository.ReadAll().OrderBy(x => x.Speciality).ToList();
        }
    }
}
