using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Presenters
{
    class PLogin
    {
        private ILogin vLogin;
        // Get data from view.
        public PLogin(ILogin view) => this.vLogin = view;

        // Calling User Credential checking method from Models.
        public (string user, int ID) GetLogin()
        {
            Login login = new Login();
            login.Username = vLogin.Username;
            login.Password = vLogin.Password;
            int ID = login.credCheck();
            //Console.WriteLine(ID);
            if (ID>=1)
            {
                return (vLogin.Username, ID);
            }
            else
                return ("Login ",0);
        }
    }
}
