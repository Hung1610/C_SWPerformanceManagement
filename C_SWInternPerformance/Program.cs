using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            F000_Login login = new F000_Login();
            login.Show();
            Application.Run();
        }
        /*
        public static bool OpenDetailFormOnClose { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OpenDetailFormOnClose = false;

            Application.Run(new F000_Login());

            if (OpenDetailFormOnClose)
            {
                Application.Run(new F001_Main(Username));
            }
        }
        */
    }

}
