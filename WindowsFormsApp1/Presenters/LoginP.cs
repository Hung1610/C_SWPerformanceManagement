using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Presenters
{
    class LoginP
    {
        private ILogin vLogin;
        
        public LoginP(ILogin view) => this.vLogin = view;
        public (string user, string pass) GetLogin()
        {
            Login login = new Login();
            login.Username = vLogin.Username;
            login.Password = vLogin.Password;
            //Console.WriteLine(login.credCheck());
            if (login.credCheck()==1)
            {
                return (vLogin.Username, vLogin.Password);
            }
            else
                return ("Login ", "Failure");
        }
    }
}
