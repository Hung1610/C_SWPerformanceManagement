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
        // Declare presenter.
        private PLogin loginP { get; set; }
        // This region implements ILogin elements.
        #region
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
        #endregion
        
        // Initilize UI components along with some data.
        public F000_Login()
        {
            loginP = new PLogin(this);
            InitializeComponent();
            passTxt.UseSystemPasswordChar = true;
            this.ControlBox = false;
        }

        // Login button
        private void button1_Click(object sender, EventArgs e)
        {
            int ID = loginP.GetLogin().ID;
            if (ID == 0)
            {
                Console.WriteLine("Login Failed");
                MessageBox.Show("Wrong Username or Password", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                F001_Main main = new F001_Main(Username,ID);
                main.Show();
                this.Close();
            }
        }

        // Close button.
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
