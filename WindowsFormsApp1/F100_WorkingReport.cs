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
    public partial class F100_WorkingReport : Form, IProjectReport
    {
        int UserID;

        private ProjectReportP pReport{ get; set; }
        public int EmployeeID
        {
            get
            {
                return UserID;
            }
        }
        public int ProjectID
        {
            get
            {
                ProjectAssignData current = projectBox.SelectedValue as ProjectAssignData;
                return current.ProjectID;
            }
        }
        public int WorkingTime
        {
            get
            {
                int WorkTime = Convert.ToInt32(workTimeUpDown.Value);
                return WorkTime;
            }
        }
        public string Remark
        {
            get
            {
                return remarkRichTxt.Text;
            }
        }
        public string ProjectName
        {
            get
            {
                ProjectAssignData current = projectBox.SelectedValue as ProjectAssignData;
                return current.ProjectName;
            }
        }
        public DateTime Date
        {
            get
            {
                return datePick.Value;
            }
        }
        public F100_WorkingReport(int ID)
        { 
            InitializeComponent();
            UserID = ID;
            pReport = new ProjectReportP(this); 
            List <ProjectAssignData> projectList = pReport.assignList();
            foreach (ProjectAssignData pData in projectList)
            {
                projectBox.Items.Add(pData);
            }
            projectBox.DisplayMember = "ProjectName";
        }

        private void projectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (projectBox.SelectedValue != null)
            {
                ProjectAssignData current = projectBox.SelectedValue as ProjectAssignData;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
