using System;
using System.Windows.Forms;

namespace RegExClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(args.Length > 0 ? new RegExClientForm(args[0]) : new RegExClientForm(string.Empty));
        }
    }
}
