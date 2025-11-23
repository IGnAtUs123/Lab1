using DataAccessLayer;
using Logic;

namespace View
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var repo = new EfRepository();

            var lg = new Logic.Logic(repo); 

            Application.Run(new Main(lg));
        }
    }
}
