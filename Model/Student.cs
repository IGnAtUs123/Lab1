namespace WpfMvvmApp.Model
{
    public class Student
    {
        public int Id { get; set; } // Номер записи
        public string FullName { get; set; }          // ФИО
        public string Specialization { get; set; }    // Специализация
        public string Group { get; set; }             // Группа
        public string StudentCardNumber { get; set; } // Номер студенческого билета
    }
}
