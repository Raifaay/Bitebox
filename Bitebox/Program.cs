using Bitebox.Views;
using Bitebox.Views.Admin;

namespace Bitebox
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());
        }
    }
}