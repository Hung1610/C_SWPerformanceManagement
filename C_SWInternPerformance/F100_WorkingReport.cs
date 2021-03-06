﻿using System;
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
    public partial class F100_WorkingReport : CommonForm, IProjectReport
    {
        // Message box strings.
        string SubmitConfirmTitle = "Confirm Submit";
        string SubmitConfirmMessage = "Submit this report ?";
        string SubmitConfirmOk = "Report Submitted.";

        string ExceptionErrorTitle = "Exception Error";
        string ExceptionErrorMeessage = "There was an error with a database query. Please check the error log.";

        // User ID gotten from Main.
        int UserID;

        // Declare presenters.
        private PProjectReport PReport;

        // Events to refresh F001_Main.
        public delegate void RefreshEventHandler(object sender, EventArgs e);
        public event RefreshEventHandler ReportRefresh;

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

        // Make dragging Title Panel drag the form around.
        #region Title Panel Mouse events.
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            base.PanelMove_MouseMove(sender, e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            base.PanelMove_MouseDown(sender, e);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            base.PanelMove_MouseUp(sender, e);
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
                try
                {
                    PReport = new PProjectReport(this);
                    PReport.Submit();
                    ReportRefresh?.Invoke(this, new EventArgs());
                    MessageBox.Show(SubmitConfirmOk);
                }
                catch (Exception)
                {
                    MessageBox.Show(ExceptionErrorMeessage, ExceptionErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Close button.
        public new void Close_Click(object sender, EventArgs e)
        {
            base.Close_Click(sender, e);
            this.Close();
        }

    }
}
