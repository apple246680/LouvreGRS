using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LouvreGRS
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
            Application.ThreadException += HandleUnhandledException;
            Application.Run(new Main());
        }
        private static void HandleUnhandledException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"異常: {e.Exception.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
