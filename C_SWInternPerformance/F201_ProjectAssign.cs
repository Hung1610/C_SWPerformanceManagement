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
    public partial class F201_ProjectAssign : Form,IProjectAssign
    {
        // Declare presenter.
        private PProjectAssign pAssign;
        // Lists to populate with database data.
        BindingList<ProjectAssignData> projectList;
        BindingSource assignedList = new BindingSource();
        BindingList<ProjectsData> pNameList;
        BindingList<ProjectsData> selectProjectList;
        BindingList<EmployeeData> selectEmployeeList;
        BindingList<RoleData> selectRoleList;

        // Initialize UI components and some data.
        public F201_ProjectAssign()
        {
            InitializeComponent();
            // Disable top box control.
            this.ControlBox = false;
        }
        private void F201_ProjectAssign_Load(object sender, EventArgs e)
        {
            RefreshButton.BackgroundImageLayout = ImageLayout.Stretch;
            // Getting the necessary lists.
            pAssign = new PProjectAssign(this);
            projectList = pAssign.AssignList();
            pNameList = pAssign.GetProjects();
            // DataGridView Lists
            selectProjectList = pAssign.GetProjects();
            selectProjectList.RemoveAt(0);
            selectEmployeeList = pAssign.GetEmployeeDatas();
            selectRoleList = pAssign.GetRoleDatas();
            // Setting Datasource for the combobox, DataGridView
            projectNameBox.DataSource = pNameList;
            projectNameBox.DisplayMember = "ProjectName";
            dataProjectAssign.DataSource = assignedList;
            assignedList.DataSource = new BindingList<ProjectAssignData>(projectList.OrderBy(x => x.ProjectName).ToList());
            // Setting some attributes for the DataGrid. Rename the columns.
            // Hide the ProjectName Column to replace with a combobox.
            dataProjectAssign.Columns["ProjectName"].Visible = false;
            ProjectCol.DataPropertyName = "ProjectName";
            ProjectCol.DataSource = selectProjectList;
            middleProjectBox.DataSource = selectProjectList;
            middleProjectBox.ValueMember = "ProjectID";
            ProjectCol.DisplayMember = "ProjectName";
            //ProjectCol.ValueMember = "ProjectID".ToString();
            //
            // Hide the EmployeeName column and replace with a combobox
            dataProjectAssign.Columns["EmployeeName"].Visible = false;
            EmployeeCol.DataPropertyName = "EmployeeName";
            EmployeeCol.DataSource = selectEmployeeList;
            middleEmpBox.DataSource = selectEmployeeList;
            middleEmpBox.ValueMember = "EmployeeID";
            EmployeeCol.DisplayMember = "EmployeeName";
            //EmployeeCol.ValueMember = "EmployeeID";
            //
            // Hide the Role column and replace with a combobox
            dataProjectAssign.Columns["Role"].Visible = false;
            RoleCol.DataPropertyName = "Role";
            RoleCol.DataSource = selectRoleList;
            middleRoleBox.DataSource = selectRoleList;
            middleRoleBox.ValueMember = "RoleID";
            RoleCol.DisplayMember = "RoleName";
            //RoleCol.ValueMember = "RoleID";
            //
            dataProjectAssign.Columns["StartDate"].HeaderText = "Start Date";
            dataProjectAssign.Columns["EndDate"].HeaderText = "End Date";
            dataProjectAssign.Columns["ProjectAssignID"].Visible = false;
            dataProjectAssign.Columns["ProjectID"].Visible = false;
            dataProjectAssign.Columns["EmployeeID"].Visible = false;
            dataProjectAssign.Columns["RoleID"].Visible = false;
            // Setting autosize mode.
            EmployeeCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ProjectCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataProjectAssign.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // This region is for implementing IProjectAssign elements.
        #region IProjectAssign ELEMENTS

        public int ProjectAssignID
        {
            get
            {
                if (dataProjectAssign.CurrentRow == null)
                {
                    return 0;
                }
                var value = dataProjectAssign.CurrentRow.Cells["ProjectAssignID"].Value;
                return (int)value;
            }
        }
        public int ProjectID
        {
            get
            {
                if (dataProjectAssign.CurrentRow == null)
                {
                    return 0;
                }
                ProjectsData currentPro = (ProjectsData)middleProjectBox.SelectedItem;
                var value = currentPro.ProjectID;
                return (int)value;
            }
        }
        public int EmployeeID
        {
            get
            {
                if (dataProjectAssign.CurrentRow == null)
                {
                    return 0;
                }
                EmployeeData currentEmp = (EmployeeData)middleEmpBox.SelectedItem;
                var value = currentEmp.EmployeeID;
                return (int)value;
            }
        }
        public int ProjectRoleID
        {
            get
            {
                if (dataProjectAssign.CurrentRow == null)
                {
                    return 0;
                }
                RoleData currentRole = (RoleData)middleRoleBox.SelectedItem;
                var value = currentRole.RoleID;
                return (int)value;
            }
        }
        public string ProjectName
        {
            get
            {
                if (dataProjectAssign.CurrentRow == null)
                {
                    return "";
                }
                var value = Convert.ToString(dataProjectAssign.CurrentRow.Cells["ProjectCol"].Value);
                return value;
            }
        }
        public string EmployeeName
        {
            get
            {
                if (dataProjectAssign.CurrentRow == null)
                {
                    return "";
                }
                var value = Convert.ToString(dataProjectAssign.CurrentRow.Cells["EmployeeCol"].Value);
                return value;
            }
        }
        public string Role
        {
            get
            {
                if (dataProjectAssign.CurrentRow == null)
                {
                    return "";
                }
                var value = Convert.ToString(dataProjectAssign.CurrentRow.Cells["RoleCol"].Value);
                return value;
            }
        }
        public string Remark
        {
            get
            {
                if (dataProjectAssign.CurrentRow == null)
                {
                    return "";
                }
                var remark = Convert.ToString(dataProjectAssign.CurrentRow.Cells["Remark"].Value);
                return remark;
            }
        }
        public DateTime StartDate
        {
            get
            {
                if (dataProjectAssign.CurrentRow == null)
                {
                    return DateTime.Now;
                }
                var value = dataProjectAssign.CurrentRow.Cells["StartDate"].Value;
                DateTime date = Convert.ToDateTime(value);
                return date;
            }
        }
        public DateTime EndDate
        {
            get
            {
                if (dataProjectAssign.CurrentRow == null)
                {
                    return DateTime.Now;
                }
                var value = dataProjectAssign.CurrentRow.Cells["EndDate"].Value;
                DateTime date = Convert.ToDateTime(value);
                return date;
            }
        }

        #endregion

        // DataGridView Interactions. List to store changed data.
        ProjectAssignData newdata;
        List<ProjectAssignData> ChangedList = new List<ProjectAssignData>();
        // List to store deleted data.
        List<int> DeleteList = new List<int>();

        // Refresh function
        private void RefreshForm()
        {
            pAssign = new PProjectAssign(this);
            projectNameBox.SelectedIndex = 0;
            projectList = pAssign.AssignList();
            assignedList.DataSource = new BindingList<ProjectAssignData>(projectList.OrderBy(x => x.ProjectName).ToList());
        }

        // Listen to refresh event from F201_ProjectAssignAdd.
        private void RefreshRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Project Assigned!");
            this.RefreshForm();
        }

        // Handle Combobox selection.
        private void ProjectNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectsData current = projectNameBox.SelectedItem as ProjectsData;
            if (current.ProjectID == -1)
            {
                assignedList.DataSource = new BindingList<ProjectAssignData>(projectList.OrderBy(x => x.ProjectName).ToList());
                
            }
            else
            {
                BindingList<ProjectAssignData> filteredList = new BindingList<ProjectAssignData>(projectList.Where(o => o.ProjectID.Equals(current.ProjectID) == true).ToList());
                assignedList.DataSource = new BindingList<ProjectAssignData>(filteredList.OrderBy(x => x.RoleID).ToList());
            }
        }


        // Event that fires when a row is entered. Give the selected row fancy color.
        private void DataProjectAssign_RowEnter(object sender,DataGridViewCellEventArgs e)
        {
            if(dataProjectAssign.CurrentRow != null)
            {
                middleProjectBox.SelectedValue = dataProjectAssign.Rows[e.RowIndex].Cells["ProjectID"].Value;
                middleEmpBox.SelectedValue = dataProjectAssign.Rows[e.RowIndex].Cells["EmployeeID"].Value;
                middleRoleBox.SelectedValue = dataProjectAssign.Rows[e.RowIndex].Cells["RoleID"].Value;
                for (int i = 0; i < dataProjectAssign.Rows[e.RowIndex].Cells.Count; i++)
                {
                    dataProjectAssign[i, e.RowIndex].Style.BackColor = Color.Yellow;
                }
            }
        }

        // Event that fires when a row is left, AFTER validating, firing after CellEditEnd events. Create new data for changedList.
        private void DataProjectAssign_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            for (int i = 0; i < dataProjectAssign.Rows[e.RowIndex].Cells.Count; i++)
            {
                dataProjectAssign[i, e.RowIndex].Style.BackColor = Color.Empty;
            }
            if (dataProjectAssign.IsCurrentRowDirty)
            {
                newdata = new ProjectAssignData
                {
                    ProjectAssignID = Convert.ToInt32(dataProjectAssign.CurrentRow.Cells["ProjectAssignID"].Value),
                    ProjectID = this.ProjectID,
                    EmployeeID = this.EmployeeID,
                    RoleID = this.ProjectRoleID,
                    ProjectName = this.ProjectName,
                    EmployeeName = this.EmployeeName,
                    Role = this.Role,
                    Remark = this.Remark,
                    StartDate = this.StartDate,
                    EndDate = this.EndDate
                };
                ChangedList.Add(newdata);
                Console.WriteLine("Data changes saved.");
            }
        }

        // Fires when user delete row.
        private void DataProjectAssign_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            foreach (DataGridViewRow row in dataProjectAssign.SelectedRows)
            {
                DeleteList.Add((int)row.Cells["ProjectAssignID"].Value);
            }
        }

        // Open a new form to add new project Assignment.
        private void AddButton_Click(object sender, EventArgs e)
        {
            F201_ProjectAssignAdd Add = new F201_ProjectAssignAdd();
            Add.AssignRefresh += RefreshRequest;
            Add.Show();
        }

        // Save button.
        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Carry out the changes ?",
                                                    "Executing Query",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (int DeleteID in DeleteList)
                {
                    pAssign.DeleteAssign(DeleteID);
                }
                foreach (ProjectAssignData projectAssign in ChangedList)
                {
                    pAssign.UpdateAssign(projectAssign);
                }
                foreach(ProjectAssignData data in ChangedList)
                {
                    Console.WriteLine(data.ProjectID + " " + data.EmployeeID + " " + data.RoleID);
                }
            }
            ChangedList.Clear();
            DeleteList.Clear();
            this.RefreshForm();
        }


        // Refresh button to undo changes.
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ChangedList.Clear();
            DeleteList.Clear();
            this.RefreshForm();
        }
        
        // Close button.
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataProjectAssign_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //DO NOTHING
            //FUCK DATAGRIDVIEW COMBOBOX
        }
    }
}
