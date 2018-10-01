﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_SWInternPerformance.Presenters;
using MaterialSkin;
using MaterialSkin.Controls;

namespace C_SWInternPerformance
{
    public partial class F000_Login : CommonForm, ILogin
    {
        // Message box strings.
        string LoginErrorTitle = "Login Error";
        string LoginErrorMessage = "Wrong user Name or Password";

        // Declare presenter.
        private PLogin LoginP { get; set; }
        // This region implements ILogin elements.
        #region
        public string Username
        {
            get
            {
                return flatTxtUser.Text;
            }
        }

        public string Password
        {
            get
            {
                return flatTxtPass.Text;
            }
        }
        #endregion

        // This region sets up textbox watermark.
        #region Setting up Watermark for the textboxes


        private void passTxt_Enter(object sender, EventArgs e)
        {
            if (flatTxtPass.Text == "Password")
            {
                flatTxtPass.Text = "";
                flatTxtPass.ForeColor = Color.Black;
                flatTxtPass.UseSystemPasswordChar = true;
            }
        }

        private void passTxt_Leave(object sender, EventArgs e)
        {
            if (flatTxtPass.Text == "")
            {
                flatTxtPass.Text = "Password";
                flatTxtPass.UseSystemPasswordChar = false;
                flatTxtPass.ForeColor = Color.Silver;
            }
        }

        private void userTxt_Enter(object sender, EventArgs e)
        {
            if (flatTxtUser.Text == "Enter Email")
            {
                flatTxtUser.Text = "";
                flatTxtUser.ForeColor = Color.Black;
            }
        }

        private void userTxt_Leave(object sender, EventArgs e)
        {
            if (flatTxtUser.Text == "")
            {
                flatTxtUser.Text = "Enter Email";
                flatTxtUser.ForeColor = Color.Silver;
            }
        }

        #endregion

        // Make dragging Title Panel drag the form around.
        #region Title Panel Mouse events.
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            base.PanelMove_MouseDown(sender, e);
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            base.PanelMove_MouseMove(sender, e);
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            base.PanelMove_MouseUp(sender, e);
        }
        #endregion

        // Initilize UI components along with some data.
        public F000_Login()
        {
            LoginP = new PLogin(this);
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        // Login button
        private void Login_Click(object sender, EventArgs e)
        {
            int ID = LoginP.GetLogin().ID;
            if (ID == 0)
            {
                Console.WriteLine("Login Failed");
                MessageBox.Show(LoginErrorMessage, LoginErrorTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                F001_Main main = new F001_Main(ID);
                main.Show();
                this.Close();
            }
        }

        // Close button.
        private new void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
