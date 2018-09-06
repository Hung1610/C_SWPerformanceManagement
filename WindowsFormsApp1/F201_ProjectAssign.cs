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
    public partial class F201_ProjectAssign : Form ,IProjectAssign
    {
        // Declare presenter.
        private PProjectAssign pAssign;
        // Lists to populate with database data.
        BindingList<ProjectAssignData> projectList;
        BindingList<ProjectsData> pNameList;

        // Initialize UI components and some data.
        public F201_ProjectAssign()
        {
            InitializeComponent();
            // Disable top box control.
            this.ControlBox = false;
            // Getting the necessary lists.
            pAssign = new PProjectAssign(this);
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
            dataProjectAssign.Columns["ProjectAssignID"].Visible = false;
            dataProjectAssign.Columns["ProjectID"].Visible = false;
            dataProjectAssign.Columns["EmployeeID"].Visible = false;
            dataProjectAssign.Columns["RoleID"].Visible = false;
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
        public string ProjectName
        {
            get
            {
                var value = Convert.ToString(dataProjectAssign.CurrentRow.Cells["ProjectName"].Value);
                return value;
            }
        }
        public string EmployeeName
        {
            get
            {
                var value = Convert.ToString(dataProjectAssign.CurrentRow.Cells["EmployeeName"].Value);
                return value;
            }
        }
        public string Role
        {
            get
            {
                var value = Convert.ToString(dataProjectAssign.CurrentRow.Cells["Role"].Value);
                return value;
            }
        }
        public string Remark
        {
            get
            {
                var value = Convert.ToString(dataProjectAssign.CurrentRow.Cells["Remark"].Value);
                return value;
            }
        }
        public DateTime StartDate
        {
            get
            {
                var value = dataProjectAssign.CurrentRow.Cells["StartDate"].Value;
                DateTime date = Convert.ToDateTime(value);
                return date;
            }
        }
        public DateTime EndDate
        {
            get
            {
                var value = dataProjectAssign.CurrentRow.Cells["EndDate"].Value;
                DateTime date = Convert.ToDateTime(value);
                return date;
            }
        }

        #endregion

        // Close button.
        private void close_Click(object sender, EventArgs e)
        {
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
            }
            else
            {
                BindingList<ProjectAssignData> filteredList = new BindingList<ProjectAssignData>(projectList.Where(o => o.ProjectID.Equals(current.ProjectID) == true).ToList());
                dataProjectAssign.DataSource = filteredList;
            }
        }

        // DataGridView Interactions.
        ProjectAssignData newdata;
        List<ProjectAssignData> changedList = new List<ProjectAssignData>();

        // Event that fires when a row is entered.
        private void dataProjectAssign_RowEnter(object sender,DataGridViewCellEventArgs e)
        {
            if(dataProjectAssign.CurrentRow != null)
            {
                for (int i = 0; i < dataProjectAssign.Rows[e.RowIndex].Cells.Count; i++)
                {
                    dataProjectAssign[i, e.RowIndex].Style.BackColor = Color.Yellow;
                }
            }
        }

        // Fires when a row is left. Add the row if it was changed into changedList.
        private void dataProjectAssign_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataProjectAssign.Rows[e.RowIndex].Cells.Count; i++)
            {
                dataProjectAssign[i, e.RowIndex].Style.BackColor = Color.Empty;
            }
            if (dataProjectAssign.IsCurrentRowDirty)
            {
                newdata = new ProjectAssignData();
                newdata.ProjectID = Convert.ToInt32(dataProjectAssign.CurrentRow.Cells["ProjectID"].Value);
                newdata.EmployeeID = Convert.ToInt32(dataProjectAssign.CurrentRow.Cells["EmployeeID"].Value);
                newdata.ProjectAssignID = Convert.ToInt32(dataProjectAssign.CurrentRow.Cells["ProjectAssignID"].Value);
                newdata.RoleID = Convert.ToInt32(dataProjectAssign.CurrentRow.Cells["RoleID"].Value);
                newdata.ProjectName = Convert.ToString(dataProjectAssign.CurrentRow.Cells["ProjectName"].Value);
                newdata.EmployeeName = Convert.ToString(dataProjectAssign.CurrentRow.Cells["EmployeeName"].Value);
                newdata.Role = Convert.ToString(dataProjectAssign.CurrentRow.Cells["Role"].Value);
                newdata.Remark = Convert.ToString(dataProjectAssign.CurrentRow.Cells["Remark"].Value);
                newdata.StartDate = Convert.ToDateTime(dataProjectAssign.CurrentRow.Cells["StartDate"].Value);
                newdata.EndDate = Convert.ToDateTime(dataProjectAssign.CurrentRow.Cells["EndDate"].Value);
                changedList.Add(newdata);
                Console.WriteLine("New data created.");
            }
        }
    }
}
