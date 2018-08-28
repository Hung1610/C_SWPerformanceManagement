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
