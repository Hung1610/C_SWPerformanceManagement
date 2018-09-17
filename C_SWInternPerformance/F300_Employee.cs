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
    public partial class F300_Employee : Form
    {
        // Declare presenter.
        private PEmployee pEmployee;
        // Lists to populate with database data.
        BindingList<PositionData> posList;
        BindingList<LevelData> lvlList;
        BindingList<BranchData> branchList;

        public F300_Employee()
        {
            this.ControlBox = false;
            InitializeComponent();
        }

        private void F300_Employee_Load(object sender, EventArgs e)
        {
            pEmployee = new PEmployee();
            // Populate the lists. 
            posList = pEmployee.GetPositions();
            lvlList = pEmployee.GetLevels();
            branchList = pEmployee.GetBranches();
            // Assign them to the comboboxes.
            posBox.DataSource = posList;
            posBox.DisplayMember = "PositionName";
            lvlBox.DataSource = lvlList;
            lvlBox.DisplayMember = "LevelName";
            braBox.DataSource = branchList;
            braBox.DisplayMember = "BranchName";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
