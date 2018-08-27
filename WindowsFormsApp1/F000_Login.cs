using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Presenters;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1
{
    public partial class F000_Login : Form, ILogin
    {
        private LoginP loginP { get; set; }
        public string Username
        {
            get
            {
                return userTxt.Text;
            }
        }

        public string Password
        {
            get
            {
                return passTxt.Text;
            }
        }

        public F000_Login()
        {
            loginP = new LoginP(this);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginP.GetLogin().pass == "Failure")
            {
                Console.WriteLine("Login Failed");
            }
            else
            {
                F001_Main main = new F001_Main(Username);
                main.Show();
            }
        }
    }
}
