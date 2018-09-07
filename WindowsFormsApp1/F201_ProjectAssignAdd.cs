using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Presenters;

namespace WindowsFormsApp1
{
    public partial class F201_ProjectAssignAdd : Form
    {
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
            pAssign = new PProjectAssign();
            // Get the list of projects and assign it to the project combobox.
            pNameList = pAssign.getPList();
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


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
