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
    public partial class F201_ProjectAssignAdd : Form, IProjectAssign
    {
        // Message box strings.
        string AssignConfirmTitle = "Assignment Confirm";
        string AssignConfirmMessage = "Assign the project ?";
        string AssignConfirmOk = "Projected assigned to selected employee.";

        // Events to interact with F201_ProjectAssign
        public delegate void RefreshEventHandler(object sender, EventArgs e);
        public event RefreshEventHandler AssignRefresh;

        // Declare presenter.
        private PProjectAssign pAssign;
        // Lists to populate with database data.
        BindingList<EmployeeData> employeeList;
        BindingList<RoleData> roleList;
        BindingList<ProjectsData> pNameList;
       
        public F201_ProjectAssignAdd()
        {
            InitializeComponent();
            this.ControlBox = false;
            pAssign = new PProjectAssign(this);
            // Get the list of projects and assign it to the project combobox.
            pNameList = pAssign.GetProjects();
            projectNameBox.DataSource = pNameList;
            projectNameBox.DisplayMember = "ProjectName";
            // Get the list of employees and assign it to the employee combobox.
            employeeList = pAssign.GetEmployeeDatas();
            employeeBox.DataSource = employeeList;
            employeeBox.DisplayMember = "EmployeeName";
            // Get the list of roles and assign it to the role combobox.
            roleList = pAssign.GetRoleDatas();
            roleBox.DataSource = roleList;
            roleBox.DisplayMember = "RoleName";
        }

        // Region to implements IProjectAssign elements
        #region IProjectAssign ELEMENTS

        public int ProjectAssignID
        {
            get
            {
                return -1;
            }
        }
        public int ProjectID
        {
            get
            {
                var current = projectNameBox.SelectedItem as ProjectsData;
                return Convert.ToInt32(current.ProjectID);
            }
        }
        public int EmployeeID
        {
            get
            {
                var current = employeeBox.SelectedItem as EmployeeData;
                return current.EmployeeID;
            }
        }
        public int ProjectRoleID
        {
            get
            {
                var current = roleBox.SelectedItem as RoleData;
                return current.RoleID;
            }
        }
        public string ProjectName
        {
            get
            {
                var current = projectNameBox.SelectedItem as ProjectsData;
                return current.ProjectName;
            }
        }
        public string EmployeeName
        {
            get
            {
                var current = employeeBox.SelectedItem as EmployeeData;
                return current.EmployeeName;
            }
        }
        public string Role
        {
            get
            {
                var current = roleBox.SelectedItem as RoleData;
                return current.RoleName;
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
                return startDatePicker.Value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return endDatePicker.Value;
            }
        }
        #endregion

        // Close the form.
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Save the Assigned Project data into database.
        private void AssignButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(AssignConfirmMessage,
                                                    AssignConfirmTitle,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int pID = this.ProjectID;
                Console.WriteLine(pID);
                if (pID == -1)
                {
                    foreach(ProjectsData project in pNameList)
                    {
                        if (project.ProjectID != -1)
                        {
                            int ID = Convert.ToInt32(project.ProjectID);
                            pAssign = new PProjectAssign(this);
                            pAssign.AddAssign(ID);
                        }
                    }
                }
                else
                {
                    pAssign = new PProjectAssign(this);
                    pAssign.AddAssign(pID);
                }
                AssignRefresh?.Invoke(this, new EventArgs());
                MessageBox.Show(AssignConfirmOk);
            }
        }
    }
}
