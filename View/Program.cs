using bus;
using DataAccessLayer;
using Logic;

namespace View
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Выбор реализации:
            IRepository<Student> repo;

            // Использовать EF:
            //repo = new EfRepository();

            // Или использовать Dapper:
            repo = new DapperRepository();

            var logic = new Logic.Logic(repo);
            Application.Run(new Main(logic));
        }
    }
}
