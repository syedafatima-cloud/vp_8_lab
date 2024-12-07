using CustomerDataApp;
using System;
using System.Windows.Forms;

namespace Lab_8
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the application with the main form
            Application.Run(new MainForm());
        }
    }
}
