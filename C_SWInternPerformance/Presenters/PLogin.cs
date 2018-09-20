using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_SWInternPerformance.Models;

namespace C_SWInternPerformance.Presenters
{
    class PLogin:BasePresenter
    {
        private ILogin vLogin;
        // Get data from view.
        public PLogin(ILogin view) => this.vLogin = view;

        // Calling User Credential checking method from Models.
        public (string user, int ID) GetLogin()
        {
            Login login = new Login
            {
                Username = vLogin.Username,
                Password = vLogin.Password
            };
            int ID = login.CredCheck();
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
