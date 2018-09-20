using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_SWInternPerformance.Presenters;

namespace C_SWInternPerformance
{
    public partial class F000_Login : Form, ILogin
    {
        // Declare presenter.
        private PLogin LoginP { get; set; }
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

        // This region sets up textbox watermark.
        #region Setting up Watermark for the textboxes

        // Close button.
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passTxt_Enter(object sender, EventArgs e)
        {
            if (passTxt.Text == "Password")
            {
                passTxt.Text = "";
                passTxt.ForeColor = Color.Black;
                passTxt.UseSystemPasswordChar = true;
            }
        }

        private void userTxt_Enter(object sender, EventArgs e)
        {
            if (userTxt.Text == "Enter email")
            {
                userTxt.Text = "";
                userTxt.ForeColor = Color.Black;
            }
        }

        private void userTxt_Leave(object sender, EventArgs e)
        {
            if (userTxt.Text == "")
            {
                userTxt.Text = "Enter email";
                userTxt.ForeColor = Color.Silver;
            }
        }

        private void passTxt_Leave(object sender, EventArgs e)
        {
            if (passTxt.Text == "")
            {
                passTxt.Text = "Password";
                passTxt.UseSystemPasswordChar = false;
                passTxt.ForeColor = Color.Silver;
            }
        }
        #endregion

        // Initilize UI components along with some data.
        public F000_Login()
        {
            LoginP = new PLogin(this);
            InitializeComponent();
            this.ControlBox = false;
        }

        // Login button
        private void Button1_Click(object sender, EventArgs e)
        {
            int ID = LoginP.GetLogin().ID;
            if (ID == 0)
            {
                Console.WriteLine("Login Failed");
                MessageBox.Show("Wrong Username or Password", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Name = LoginP.GetUser(ID);
                F001_Main main = new F001_Main(Name,ID);
                main.Show();
                this.Close();
            }
        }
    }
}
