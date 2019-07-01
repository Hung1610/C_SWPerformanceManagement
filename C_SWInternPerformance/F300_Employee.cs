using C_SWInternPerformance.Data;
using C_SWInternPerformance.Presenters;
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
    public partial class F300_Employee : CommonForm,IEmployee
    {
        // Message box strings.
        string SaveConfirmTitle = "Save Confirm";
        string SaveConfirmMessage = "Update this employee Info ?";
        string SaveConfirmOk = "Employee Info Saved.";

        string CreateConfirmTitle = "Create confirm";
        string CreateConfirmMessage = "Create a new employee ?";
        string CreateConfirmOk = "Employee Created.";

        string EmptyWarningTitle = "Field Empty";
        string EmptyWarningMessage = "Please enter employee name!";

        // ID gotten from main for use in Edit mode.
        int editID = -1;

        // Declare presenter.
        static private PEmployee pEmployee = new PEmployee();
        // Lists to populate with database data.
        BindingList<EmployeeData> employeeList = pEmployee.GetEmployees();
        BindingList<PositionData> posList = pEmployee.GetPositions();
        BindingList<LevelData> lvlList = pEmployee.GetLevels();
        BindingList<BranchData> branchList = pEmployee.GetBranches();

        // Auto complete for employee name text field.
        AutoCompleteStringCollection AutoCompleteSource;

        // Events to refresh F001_Main.
        public delegate void RefreshEventHandler(object sender, EventArgs e);
        public event RefreshEventHandler EmployeeRefresh;

        // Create mode.
        public F300_Employee()
        {
            pEmployee = new PEmployee(this);
            this.ControlBox = false;
            InitializeComponent();
            saveButton.Text = "CREATE";

            // Assign lists to the comboboxes.
            boxPos.DataSource = posList;
            boxPos.DisplayMember = "PositionName";
            boxPos.ValueMember = "PositionID";
            boxLvl.DataSource = lvlList;
            boxLvl.DisplayMember = "LevelName";
            boxLvl.ValueMember = "LevelID";
            boxBra.DataSource = branchList;
            boxBra.DisplayMember = "BranchName";
            boxBra.ValueMember = "BranchID";
        }
        // Edit Mode.
        public F300_Employee(int ID)
        {
            pEmployee = new PEmployee(this);
            this.ControlBox = false;
            InitializeComponent();
            editID = ID;
            labelTitle.Text = "Edit Employee";
            labelEmpID.Visible = true;
            txtID.Text = editID.ToString();
            txtID.Visible = true;
            saveButton.Text = "SAVE";

            // Assign lists to the comboboxes.
            boxPos.DataSource = posList;
            boxPos.DisplayMember = "PositionName";
            boxPos.ValueMember = "PositionID";
            boxLvl.DataSource = lvlList;
            boxLvl.DisplayMember = "LevelName";
            boxLvl.ValueMember = "LevelID";
            boxBra.DataSource = branchList;
            boxBra.DisplayMember = "BranchName";
            boxBra.ValueMember = "BranchID";
            // Show the data of the currently being edited employee.
            DetailedEmployeeData employee = pEmployee.GetEmployee(ID);
            txtName.Text = employee.EmployeeName;
            boxPos.SelectedValue = employee.PositionID;
            boxBra.SelectedValue = employee.BranchID;
            datePickStart.Value = employee.StartDate;
            datePickEnd.Value = employee.EndDate;
            txtEmail.Text = employee.Email;
            txtMobile.Text = employee.Mobile;
            txtAddress.Text = employee.Address;
            datePickBirth.Value = employee.Birthday;
            boxLvl.SelectedValue = employee.LevelID;
            txtDesire.Text = employee.Desire;
            if (employee.Del == 1)
                checkDel.Checked = true;
            else checkDel.Checked = false;
            richTxtRemark.Text = employee.Remark;
        }

        private void F300_Employee_Load(object sender, EventArgs e)
        {
            AutoCompleteSource = new AutoCompleteStringCollection();
            // Strings for Project Name suggestions.
            foreach (EmployeeData employee in employeeList)
            {
                UtilFormFunctions.AddUnique(AutoCompleteSource, employee.EmployeeName);
            }
            // Set Autocomplete source.
            txtName.AutoCompleteCustomSource = AutoCompleteSource;
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

        // This region implements IEmployee interface elements.
        #region IEmployee ELEMENTS
        public int EmployeeID
        {
            get
            {
                return editID;
            }
        }
        public string EmployeeName
        {
            get
            {
                return txtName.Text;
            }
        }
        public int PositionID
        {
            get
            {
                return Convert.ToInt32(boxPos.SelectedValue);
            }
        }
        public int BranchID
        {
            get
            {
                var current = (BranchData)boxBra.SelectedItem;
                return current.BranchID;
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
        public string Email
        {
            get
            {
                return txtEmail.Text;
            }
        }
        public string Mobile
        {
            get
            {
                return txtMobile.Text;
            }
        }
        public string Address
        {
            get
            {
                return txtAddress.Text;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return datePickBirth.Value;
            }
        }
        public int LevelID
        {
            get
            {
                var current = (LevelData)boxLvl.SelectedItem;
                return current.LevelID;
            }
        }
        public string Remark
        {
            get
            {
                return richTxtRemark.Text;
            }
        }
        public string Desire
        {
            get
            {
                return txtDesire.Text;
            }
        }
        public int Del
        {
            get
            {
                if (checkDel.Checked == true)
                {
                    return 1;
                }
                else return 0;
            }
        }
        #endregion
        
        // Save/Add button.
        private void saveButton_Click(object sender, EventArgs e)
        {
            bool hasOnlyWhite = EmployeeName.Length > 0 &&
                        EmployeeName.Trim().Length == 0;
            if (hasOnlyWhite || EmployeeName.Equals(""))
            {
                labelName.ForeColor = Color.Red;
                MessageBox.Show(EmptyWarningMessage,
                            EmptyWarningTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            labelName.ForeColor = Color.Black;
            if (editID != -1)
            {
                DialogResult result = MessageBox.Show(SaveConfirmMessage,
                                                    SaveConfirmTitle,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    pEmployee.Save(editID);
                    EmployeeRefresh?.Invoke(this, new EventArgs());
                    MessageBox.Show(SaveConfirmOk);
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
                    pEmployee.Save(editID);
                    EmployeeRefresh?.Invoke(this, new EventArgs());
                    MessageBox.Show(CreateConfirmOk);
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
