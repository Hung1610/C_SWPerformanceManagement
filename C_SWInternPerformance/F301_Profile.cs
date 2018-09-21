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
    public partial class F301_Profile : Form,IProfile
    {
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
                MessageBox.Show("Please enter another Email.", "Email Unavailable.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Update your Profile ?",
                                                    "Executing Query",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    pProfile.Save();
                    MessageBox.Show("Profile Updated.");
                }
            }
        }
    }
}
