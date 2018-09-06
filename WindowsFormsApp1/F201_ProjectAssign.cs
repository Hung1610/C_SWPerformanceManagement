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
    public partial class F201_ProjectAssign : Form //,IProjectAssign
    {
        // Declare presenter.
        private PProjectAssign pAssign;
        BindingList<ProjectAssignData> projectList;
        BindingList<ProjectsData> pNameList;

        // Initialize UI components and some data.
        public F201_ProjectAssign()
        {
            InitializeComponent();
            // Disable top box control.
            this.ControlBox = false;
            // Getting the necessary lists.
            pAssign = new PProjectAssign();
            projectList = pAssign.assignList();
            pNameList = pAssign.getPList();
            // Setting Datasource for the combobox.
            projectNameBox.DataSource = pNameList;
            projectNameBox.DisplayMember = "ProjectName";
            // Setting some attributes for the DataGrid. Rename the columns.
            dataProjectAssign.Columns["ProjectName"].HeaderText = "Project Name";
            dataProjectAssign.Columns["EmployeeName"].HeaderText = "Employee Name";
            dataProjectAssign.Columns["StartDate"].HeaderText = "Start Date";
            dataProjectAssign.Columns["EndDate"].HeaderText = "End Date";
            dataProjectAssign.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // This region is for implementing IProjectAssign elements.
        #region

        public int ProjectID
        {
            get
            {
                var value = dataProjectAssign.CurrentRow.Cells["ProjectID"].Value;
                return (int)value;
            }
        }
        public int EmployeeID
        {
            get
            {
                var value = dataProjectAssign.CurrentRow.Cells["EmployeeID"].Value;
                return (int)value;
            }
        }
        public int ProjectRoleID
        {
            get
            {
                var value = dataProjectAssign.CurrentRow.Cells["RoleID"].Value;
                return (int)value;
            }
        }

        #endregion
        
        // Close button.
        private void close_Click(object sender, EventArgs e)
        {
            Console.WriteLine(ProjectID);
            this.Close();
        }

        // Handle Combobox selection.
        private void projectNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectsData current = projectNameBox.SelectedItem as ProjectsData;
            if (current.ProjectID == -1)
            {
                dataProjectAssign.DataSource = projectList;/*.Select(o => new
                { EmployeeName = o.EmployeeName, Role = o.Role , StartDate = o.StartDate, EndDate = o.EndDate, Remark = o.Remark }).ToList();
                This hides the unneeded column but make things complicated.*/

                dataProjectAssign.Columns[0].Visible = false;
                dataProjectAssign.Columns[1].Visible = false;
                dataProjectAssign.Columns[2].Visible = false;
                dataProjectAssign.Columns[3].Visible = false;
            }
            else
            {
                BindingList<ProjectAssignData> filteredList = new BindingList<ProjectAssignData>(projectList.Where(o => o.ProjectID.Equals(current.ProjectID) == true).ToList());
                dataProjectAssign.DataSource = filteredList;
            }
        }
    }
}
