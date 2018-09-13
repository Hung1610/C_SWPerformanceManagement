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
    class PProjectAssign:BasePresenter
    {
        private IProjectAssign vAssign;
        public PProjectAssign(IProjectAssign view) => this.vAssign = view;
        public PProjectAssign() { }

        // A simpler list for the combobox.
        public BindingList<ProjectsData> GetProjects()
        {
            ProjectAssign project = new ProjectAssign();
            return project.ProjectList();
        }

        // This list contains more data than the other lists. For use in constructing from listview and methods interacting with SQL database.
         public BindingList<ProjectAssignData> AssignList()
        {
            ProjectAssign project = new ProjectAssign();
            return project.AssignList();
        }

        // A simple list of employees.
        public BindingList<EmployeeData> GetEmployeeDatas()
        {
            ProjectAssign project = new ProjectAssign();
            return project.GetEmployeeDatas();
        }

        // A simple list of roles.
        public BindingList<RoleData> GetRoleDatas()
        {
            ProjectAssign project = new ProjectAssign();
            return project.GetRoleDatas();
        }

        // Add new Assigned Project.
        public void AddAssign(int ID)
        {
            ProjectAssign project = new ProjectAssign
            {
                EmployeeID = vAssign.EmployeeID,
                ProjectRoleID = vAssign.ProjectRoleID,
                StartDate = vAssign.StartDate,
                EndDate = vAssign.EndDate,
                Remark = vAssign.Remark
            };
            project.AddAssign(ID);
        }

        // Delete project assignment from database.
        public void DeleteAssign(int ProjectAssignID)
        {
            ProjectAssign project = new ProjectAssign
            {
                ProjectAssignID = vAssign.ProjectAssignID
            };
            project.DeleteAssign(ProjectAssignID);
        }

        // Update project assignment in database.
        public void UpdateAssign(ProjectAssignData projectAssign)
        {
            ProjectAssign project = new ProjectAssign();
            project.UpdateAssign(projectAssign);
        }
    }
}
