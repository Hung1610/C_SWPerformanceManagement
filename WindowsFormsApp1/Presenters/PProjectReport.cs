using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Presenters
{
    class PProjectReport
    {
        private IProjectReport vReport;
        // Get data from view.
        public PProjectReport(IProjectReport view) => this.vReport = view;
        
        // Create project list.
        public List <ProjectAssignData> assignList()
        {
            ProjectReport report = new ProjectReport();
            return report.assignList();
        }

        // Calling saveReport method from Models to update the database.
        public void Submit()
        {
            ProjectReport report = new ProjectReport();
            report.ProjectID = vReport.ProjectID;
            report.EmployeeID = vReport.EmployeeID;
            report.WorkingTime = vReport.WorkingTime;
            report.Remark = vReport.Remark;
            report.ProjectName = vReport.ProjectName;
            report.Date = vReport.Date;
            report.saveReport();
        }
    }
}
