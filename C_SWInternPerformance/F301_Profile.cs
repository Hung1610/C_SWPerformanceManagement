using C_SWInternPerformance.Data;
using C_SWInternPerformance.Presenters;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SWInternPerformance
{
    public partial class F301_Profile : CommonForm,IProfile
    {
        // Message box strings.
        string EmailErrorTitle = "Email Unvailable";
        string EmailErrorMessage = "Please enter another email.";

        string SaveConfirmTitle = "Profile Update Confirm";
        string SaveConfirmMessage = "Update your profile ?";
        string SaveConfirmOk = "Profile Updated.";

        // Store the current user ID for updating.
        int userID;
        // Declare Presenter.
        PProfile pProfile;
        public F301_Profile(int ID)
        {
            InitializeComponent();
            pProfile = new PProfile(this);
            userID = ID;
            ProfileData profile = pProfile.GetProfile(ID);
            txtEmail.Text = profile.EmailAddress;
            txtPass.Text = profile.Password;
            richTxtRemark.Text = profile.Remark;
        }

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
        // This region implements IProfile elements.
        #region IProfile ELEMENTS
        public int ID
        {
            get
            {
                return userID;
            }
        }
        public string Email
        {
            get
            {
                return txtEmail.Text;
            }
        }
        public string Password
        {
            get
            {
                return txtPass.Text;
            }
        }
        public string Remark
        {
            get
            {
                return richTxtRemark.Text;
            }
        } 
        public int Del
        {
            get
            {
                if (checkDel.Checked == true)
                    return 1;
                else return 0;
            }
        }
        #endregion

        // Save Button click event.
        private void saveButton_Click(object sender, EventArgs e)
        {
            pProfile = new PProfile(this);
            if (pProfile.Save() == 0)
            {
                MessageBox.Show(EmailErrorMessage, EmailErrorTitle);
            }
            else
            {
                DialogResult result = MessageBox.Show(SaveConfirmMessage,
                                                    SaveConfirmTitle,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    pProfile.Save();
                    MessageBox.Show(SaveConfirmOk);
                }
            }
        }
        
        // Close Button.
        private void closeButton_Click(object sender, EventArgs e)
        {
            base.Close_Click(sender, e);
            this.Close();
        }
    }
}
