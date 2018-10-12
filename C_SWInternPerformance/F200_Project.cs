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
    public partial class F200_Project : CommonForm, IProjects
    {
        // Message box strings.
        string CreateConfirmTitle = "Confirm Create";
        string CreateConfirmMessage = "Create a new project ?";
        string CreateConfirmOk = "Project Created.";

        string SaveConfirmTitle = "Confirm Save";
        string SaveConfirmMessage = "Save this project ?";
        string SaveConfirmOk = "Project Saved.";

        string EmptyWarningTitle = "Field Empty";
        string EmptyWarningMessage = "Please enter project name!";

        string ExceptionErrorTitle = "Exception Error";
        string ExceptionErrorMeessage = "There was an error with a database query. Please check the error log.";

        // ID taken from main.
        int editID = -1;

        // Declare presenter.
        private PProjects pProject;
        //
        BindingList<ProjectsData> projectList;

        // Auto complete for project name text field.
        AutoCompleteStringCollection AutoCompleteSource;

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
            saveButton.Text = "CREATE";
        }
        // Initialize UI components along with some data. Edit Project form.
        public F200_Project(int eID)
        {
            this.ControlBox = false;
            InitializeComponent();
            editID = eID;
            pProject = new PProjects(this);
            projectList = pProject.ProjectList();
            saveButton.Text = "SAVE";
            labelTitle.Text = "Edit Project";
            labelProjectID.Visible = true;
            txtEditID.Text = editID.ToString();
            txtEditID.Visible = true;
            // Populate the form with current Project to edit.
            var project = pProject.GetProject(eID);
            txtProjectName.Text = project.pName;
            txtProjectInfo.Text = project.pInfo;
            txtCusName.Text = project.cName;
            txtCusInfo.Text = project.cInfo;
            richTxtRemark.Text = project.remark;
            datePickStart.Value = project.start;
            datePickEnd.Value = project.end;
        }


        private void F200_Project_Load(object sender, EventArgs e)
        {
            AutoCompleteSource = new AutoCompleteStringCollection();
            // Strings for Project Name suggestions.
            foreach (ProjectsData project in projectList)
            {
                UtilFormFunctions.AddUnique(AutoCompleteSource, project.ProjectName);
            }
            // Set Autocomplete source.
            txtProjectName.AutoCompleteCustomSource = AutoCompleteSource;
        }

        // Make dragging Title Panel drag the form around.
        #region Title Panel Mouse events.
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            base.PanelMove_MouseDown(sender, e);
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            base.PanelMove_MouseMove(sender, e);
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            base.PanelMove_MouseUp(sender, e);
        }
        #endregion

        // This region implements IProjects elements.
        #region ASSIGN VALUES TO INTERFACE MEMBERS.
        public string ProjectName
        {
            get
            {
                return txtProjectName.Text;
            }
        }
        public string ProjectInfo
        {
            get
            {
                return txtProjectInfo.Text;
            }
        }
        public string CustomerName
        {
            get
            {
                return txtCusName.Text;
            }
        }
        public string CustomerInfo
        {
            get
            {
                return txtCusInfo.Text;
            }
        }
        public string Remark
        {
            get
            {
                return richTxtRemark.Text;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return datePickStart.Value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return datePickEnd.Value;
            }
        }
        #endregion

        // Create/Save button.
        private void CreateSave_Click(object sender, EventArgs e)
        {
            bool hasOnlyWhite = ProjectName.Length > 0 &&
                        ProjectName.Trim().Length == 0;
            if (hasOnlyWhite || ProjectName == string.Empty)
            {

                MessageBox.Show(EmptyWarningMessage,
                            EmptyWarningTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (editID != -1)
            {
                DialogResult result = MessageBox.Show(SaveConfirmMessage,
                                                    SaveConfirmTitle,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        pProject.Save(editID);
                        ProjectRefresh?.Invoke(this, new EventArgs());
                        MessageBox.Show(SaveConfirmOk);
                    }
                    catch(Exception)
                    {
                        MessageBox.Show(ExceptionErrorMeessage, ExceptionErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(CreateConfirmMessage,
                                                    CreateConfirmTitle,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        pProject.Save(editID);
                        ProjectRefresh?.Invoke(this, new EventArgs());
                        MessageBox.Show(CreateConfirmOk);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(ExceptionErrorMeessage, ExceptionErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Close button.
        private void CloseButton_Click(object sender, EventArgs e)
        {
            base.Close_Click(sender, e);
            this.Close();
        }

    }
}
