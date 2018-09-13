using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_SWInternPerformance.Data;
using C_SWInternPerformance.Models;

namespace C_SWInternPerformance.Presenters
{
    class PProjectReport:BasePresenter
    {
        private IProjectReport vReport;
        // Get data from view.
        public PProjectReport(IProjectReport view) => this.vReport = view;

        // A simpler list for the combobox.
        public BindingList<ProjectsData> GetProjects()
        {
            ProjectAssign project = new ProjectAssign();
            return project.ProjectList();
        }

        // Calling saveReport method from Models to update the database.
        public void Submit()
        {
            ProjectReport report = new ProjectReport
            {
                ProjectID = vReport.ProjectID,
                EmployeeID = vReport.EmployeeID,
                WorkingTime = vReport.WorkingTime,
                Remark = vReport.Remark,
                ProjectName = vReport.ProjectName,
                Date = vReport.Date
            };
            report.SaveReport();
        }
    }
}
