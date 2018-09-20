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
    public partial class F300_Employee : Form,IEmployee
    {
        // ID gotten from main for use in Edit mode.
        int editID;
        // Declare presenter.
        static private PEmployee pEmployee = new PEmployee();
        // Lists to populate with database data.
        BindingList<PositionData> posList = pEmployee.GetPositions();
        BindingList<LevelData> lvlList = pEmployee.GetLevels();
        BindingList<BranchData> branchList = pEmployee.GetBranches();

        // Events to refresh F001_Main.
        public delegate void RefreshEventHandler(object sender, EventArgs e);
        public event RefreshEventHandler EmployeeRefresh;

        // Create mode.
        public F300_Employee()
        {
            pEmployee = new PEmployee(this);
            this.ControlBox = false;
            InitializeComponent();
            saveButton.Text = "Create";

            // Assign lists to the comboboxes.
            posBox.DataSource = posList;
            posBox.DisplayMember = "PositionName";
            posBox.ValueMember = "PositionID";
            lvlBox.DataSource = lvlList;
            lvlBox.DisplayMember = "LevelName";
            lvlBox.ValueMember = "LevelID";
            braBox.DataSource = branchList;
            braBox.DisplayMember = "BranchName";
            braBox.ValueMember = "BranchID";
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
            saveButton.Text = "Save";

            // Assign lists to the comboboxes.
            posBox.DataSource = posList;
            posBox.DisplayMember = "PositionName";
            posBox.ValueMember = "PositionID";
            lvlBox.DataSource = lvlList;
            lvlBox.DisplayMember = "LevelName";
            lvlBox.ValueMember = "LevelID";
            braBox.DataSource = branchList;
            braBox.DisplayMember = "BranchName";
            braBox.ValueMember = "BranchID";
            // Show the data of the currently being edited employee.
            DetailedEmployeeData employee = pEmployee.GetEmployee(ID);
            nameTxt.Text = employee.EmployeeName;
            posBox.SelectedValue = employee.PositionID;
            braBox.SelectedValue = employee.BranchID;
            startDatePick.Value = employee.StartDate;
            endDatePick.Value = employee.EndDate;
            emailTxt.Text = employee.Email;
            mobileTxt.Text = employee.Mobile;
            addressTxt.Text = employee.Address;
            birthDatePick.Value = employee.Birthday;
            lvlBox.SelectedValue = employee.LevelID;
            desireTxt.Text = employee.Desire;
            if (employee.Del == 1)
                delFlagCheck.Checked = true;
            else delFlagCheck.Checked = false;
            remarkRichTxt.Text = employee.Remark;
        }
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
                return nameTxt.Text;
            }
        }
        public int PositionID
        {
            get
            {
                return Convert.ToInt32(posBox.SelectedValue);
            }
        }
        public int BranchID
        {
            get
            {
                var current = (BranchData)braBox.SelectedItem;
                return current.BranchID;
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
        public string Email
        {
            get
            {
                return emailTxt.Text;
            }
        }
        public string Mobile
        {
            get
            {
                return mobileTxt.Text;
            }
        }
        public string Address
        {
            get
            {
                return addressTxt.Text;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthDatePick.Value;
            }
        }
        public int LevelID
        {
            get
            {
                var current = (LevelData)lvlBox.SelectedItem;
                return current.LevelID;
            }
        }
        public string Remark
        {
            get
            {
                return remarkRichTxt.Text;
            }
        }
        public string Desire
        {
            get
            {
                return desireTxt.Text;
            }
        }
        public int Del
        {
            get
            {
                if (delFlagCheck.Checked == true)
                {
                    return 1;
                }
                else return 0;
            }
        }
        #endregion
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editID != -1)
            {
                DialogResult result = MessageBox.Show("Update this employee ?",
                                                    "Executing Query",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    pEmployee.Save(editID);
                    MessageBox.Show("Employee Updated.");
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Create a new employee ?",
                                                    "Executing Query",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    pEmployee.Save(editID);
                    MessageBox.Show("New Employee Created.");
                }
            }
            EmployeeRefresh?.Invoke(this, new EventArgs());
        }
    }
}
