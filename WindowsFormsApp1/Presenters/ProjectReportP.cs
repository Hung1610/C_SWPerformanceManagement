using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Presenters
{
    class ProjectReportP
    {
        private IProjectReport vReport;
        public ProjectReportP(IProjectReport view) => this.vReport = view;
        public List <ProjectAssignData> assignList()
        {
            ProjectReport report = new ProjectReport();
            return report.assignList();
        }
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
