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
            passTxt.UseSystemPasswordChar = true;
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginP.GetLogin().pass == "Failure")
            {
                Console.WriteLine("Login Failed");
                MessageBox.Show("Wrong Username or Password", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                F001_Main main = new F001_Main(Username);
                main.Show();
                this.Close();
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
