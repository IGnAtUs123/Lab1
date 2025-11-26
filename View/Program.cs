using System;
using System.Windows.Forms;
using Ninject;
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

            var kernel = new StandardKernel(new SimpleConfigModule());
            var logic = kernel.Get<BusinessLogic>();

            Application.Run(new Main(logic));
        }
    }
}
