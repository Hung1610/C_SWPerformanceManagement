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
    public partial class F200_Project : Form, IProjects
    {
        // ID taken from main.
        int editID = -1;
        // Declare presenter.
        private PProjects pProject;
        //
        BindingList<ProjectsData> projectList;

        // Events to refresh F001_Main.
        public delegate void RefreshEventHandler(object sender, EventArgs e);
        public event RefreshEventHandler ProjectRefresh;

        // Initialize UI components along with some data. Create Project form.
        public F200_Project()
        {
            this.ControlBox = false;
            InitializeComponent();
            pProject = new PProjects(this);
            projectList = pProject.ProjectList();
            saveButton.Text = "Create";
        }
        // Initialize UI components along with some data. Edit Project form.
        public F200_Project(int eID)
        {
            this.ControlBox = false;
            InitializeComponent();
            editID = eID;
            pProject = new PProjects(this);
            projectList = pProject.ProjectList();
            saveButton.Text = "Save";
            labelTitle.Text = "Edit Project";
            labelProjectID.Visible = true;
            txtEditID.Text = editID.ToString();
            txtEditID.Visible = true;
            // Populate the form with current Project to edit.
            var project = pProject.GetProject(eID);
            projectNameTxt.Text = project.pName;
            projectInfoTxt.Text = project.pInfo;
            cusNameTxt.Text = project.cName;
            cusInfoTxt.Text = project.cInfo;
            remarkRichTxt.Text = project.remark;
            startDatePick.Value = project.start;
            endDatePick.Value = project.end;
        }

        // This region implements IProjects elements.
        #region ASSIGN VALUES TO INTERFACE MEMBERS.
        public string ProjectName
        {
            get
            {
                return projectNameTxt.Text;
            }
        }
        public string ProjectInfo
        {
            get
            {
                return projectInfoTxt.Text;
            }
        }
        public string CustomerName
        {
            get
            {
                return cusNameTxt.Text;
            }
        }
        public string CustomerInfo
        {
            get
            {
                return cusInfoTxt.Text;
            }
        }
        public string Remark
        {
            get
            {
                return remarkRichTxt.Text;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return startDatePick.Value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return endDatePick.Value;
            }
        }
        #endregion

        // Create/Save button.
        private void CreateSave_Click(object sender, EventArgs e)
        {
            if (editID != -1)
            {
                DialogResult result = MessageBox.Show("Update this project ?",
                                                    "Executing Query",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    pProject.Save(editID);
                    MessageBox.Show("Project Updated.");
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Create a new project ?",
                                                    "Executing Query",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    pProject.Save(editID);
                    MessageBox.Show("New project Created.");
                }
            }
            ProjectRefresh?.Invoke(this, new EventArgs());
        }

        // Close button.
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectNameTxt_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
