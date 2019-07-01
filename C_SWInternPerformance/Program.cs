using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SWInternPerformance
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string errorPath = @"ErrorLog.txt";
            if (File.Exists(errorPath))
            {
                File.Delete(errorPath);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException +=
                (sender, args) => HandleUnhandledException(args.ExceptionObject as Exception);
            Application.ThreadException +=
                (sender, args) => HandleUnhandledException(args.Exception);
            AppDomain.CurrentDomain.FirstChanceException += (sender, eventArgs) =>
            {
                string log = (DateTime.Now + " - " +
                            eventArgs.Exception.Message);
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(errorPath, true))
                {
                    file.WriteLine(log);
                }
            };
            F000_Login login = new F000_Login();
            login.Show();
            Application.Run();
        }

        // Handle exceptions
        static void HandleUnhandledException(Exception e)
        {
            // Write Log or something Doesn't work.
            Console.WriteLine("Error!");
        }
    }

}
