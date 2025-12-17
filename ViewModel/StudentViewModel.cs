using System.Collections.ObjectModel;
using System.Linq;
using WpfMvvmApp.Model;

namespace WpfMvvmApp.ViewModel
{
    public class StudentViewModel : BaseViewModel
    {
        public ObservableCollection<Student> Students { get; set; }

        // Свойства для ввода
        private string _fullName;
        public string FullName
        {
            get => _fullName;
            set { _fullName = value; OnPropertyChanged(nameof(FullName)); }
        }

        private string _specialization;
        public string Specialization
        {
            get => _specialization;
            set { _specialization = value; OnPropertyChanged(nameof(Specialization)); }
        }

        private string _group;
        public string Group
        {
            get => _group;
            set { _group = value; OnPropertyChanged(nameof(Group)); }
        }

        private string _studentCardNumber;
        public string StudentCardNumber
        {
            get => _studentCardNumber;
            set { _studentCardNumber = value; OnPropertyChanged(nameof(StudentCardNumber)); }
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }

        public StudentViewModel()
        {
            Students = new ObservableCollection<Student>();

            AddCommand = new RelayCommand(o =>
            {
                // Проверка: все поля должны быть заполнены
                if (string.IsNullOrWhiteSpace(FullName) ||
                    string.IsNullOrWhiteSpace(Specialization) ||
                    string.IsNullOrWhiteSpace(Group) ||
                    string.IsNullOrWhiteSpace(StudentCardNumber))
                {
                    System.Windows.MessageBox.Show("Заполните все поля перед добавлением!");
                    return;
                }

                Students.Add(new Student
                {
                    Id = Students.Count + 1,
                    FullName = FullName,
                    Specialization = Specialization,
                    Group = Group,
                    StudentCardNumber = StudentCardNumber
                });

                // Очистка полей
                FullName = string.Empty;
                Specialization = string.Empty;
                Group = string.Empty;
                StudentCardNumber = string.Empty;
            });

            RemoveCommand = new RelayCommand(o =>
            {
                if (string.IsNullOrWhiteSpace(StudentCardNumber))
                {
                    System.Windows.MessageBox.Show("Введите номер студенческого билета для удаления!");
                    return;
                }

                var student = Students.FirstOrDefault(s => s.StudentCardNumber == StudentCardNumber);
                if (student != null)
                {
                    Students.Remove(student);
                    StudentCardNumber = string.Empty; // очистка поля
                }
                else
                {
                    System.Windows.MessageBox.Show("Студент с таким номером билета не найден!");
                }
            });
        }
    }
}
