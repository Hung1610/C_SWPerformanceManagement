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
    public partial class F201_ProjectAssign : Form// ,IProjectAssign
    {
        private PProjectAssign pAssign;
        BindingList<ProjectAssignData> projectList;
        public F201_ProjectAssign()
        {
            InitializeComponent();
            this.ControlBox = false;
            pAssign = new PProjectAssign();
            projectList = pAssign.assignList();
            projectNameBox.DataSource = projectList;
            projectNameBox.DisplayMember = "ProjectName";
            dataProjectAssign.DataSource = projectList;/*.Select(o => new
                { EmployeeName = o.EmployeeName, Role = o.Role , StartDate = o.StartDate, EndDate = o.EndDate, Remark = o.Remark }).ToList();
                This hides the unneeded column but make things complicated.*/
           // dataProjectAssign.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }
        public int EmployeeID
        {
            get
            {
                ProjectAssignData current = projectNameBox.SelectedItem as ProjectAssignData;
                return current.ProjectID;
            }
        }
        public 

        void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void projectNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectAssignData current = projectNameBox.SelectedItem as ProjectAssignData;
        }
    }
}
