using System;
using System.Windows.Forms;
using View;
using Model;

namespace Presenter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var model = new InMemoryModel();
            var view = new MainForm();
            var presenter = new Presenter(model, view);

            presenter.Run();
        }
    }
}
