using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_SWInternPerformance.Data;
using C_SWInternPerformance.Presenters;

namespace C_SWInternPerformance
{
    public partial class F100_WorkingReport : Form, IProjectReport
    {
        // Message box strings.
        string SubmitConfirmTitle = "Confirm Submit";
        string SubmitConfirmMessage = "Submit this report ?";
        string SubmitConfirmOk = "Report Submitted.";

        // User ID gotten from Main.
        int UserID;
        // Declare presenters.
        private PProjectReport PReport;

        // Initialize UI components along with some data.
        public F100_WorkingReport(int ID)
        {
            InitializeComponent();
            this.ControlBox = false;
            UserID = ID;
            PReport = new PProjectReport(this);
            BindingList<ProjectsData> projectList = PReport.GetProjects();
            projectList.RemoveAt(0);
            projectBox.DataSource = projectList;
            projectBox.DisplayMember = "ProjectName";
        }

        // This region implements IWorkingReport elements.
        #region ASSIGN VALUES TO IProjectReport ELEMENTS.
        public int EmployeeID
        {
            get
            {
                return UserID;
            }
        }
        public int ProjectID
        {
            get
            {
                ProjectsData current = projectBox.SelectedItem as ProjectsData;
                return current.ProjectID;
            }
        }
        public Double WorkingTime
        {
            get
            {
                Double WorkTime = Convert.ToDouble(workTimeUpDown.Value);
                return WorkTime;
            }
        }
        public string Remark
        {
            get
            {
                return remarkRichTxt.Text;
            }
        }
        public string ProjectName
        {
            get
            {
                ProjectsData current = projectBox.SelectedItem as ProjectsData;
                return current.ProjectName;
            }
        }
        public DateTime Date
        {
            get
            {
                return datePick.Value;
            }
        }
        #endregion

        // Handles projectBox selection.
        private void ProjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (projectBox.SelectedValue != null)
            {
                ProjectAssignData current = projectBox.SelectedValue as ProjectAssignData;
            }
        }

        // Submit button.
        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(SubmitConfirmMessage,
                                                    SubmitConfirmTitle,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PReport = new PProjectReport(this);
                PReport.Submit();
                MessageBox.Show(SubmitConfirmOk);
            }
        }

        //Close button.
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
