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
    class PProjects
    {
        private IProjects vProject;
        // Get data from view.
        public PProjects(IProjects view) => this.vProject = view;

        // Create a project list.
        public BindingList<ProjectsData> ProjectList()
        {
            Projects project = new Projects();
            return project.ProjectList();
        }

        // Method for searching within a List of ProjectAssignDate using ProjectName
        public int ListSearch(string pName, BindingList<ProjectsData> list)
        {
            foreach (ProjectsData project in list)
            {
                if (project.ProjectName == pName)
                    return project.ProjectID;
            }
            return -1;
        }

        // Calling addProject/saveProject method from Models to INSERT/UPDATE the database.
        public int Save(int ID)
        {
            Projects project = new Projects
            {
                ProjectName = vProject.ProjectName,
                ProjectInfo = vProject.ProjectInfo,
                CustomerName = vProject.CustomerName,
                CustomerInfo = vProject.CustomerInfo,
                StartDate = vProject.StartDate,
                EndDate = vProject.EndDate,
                Remark = vProject.Remark
            };
            if (ID == -1)
            {
                project.AddProject();
                return 0;
            }
                
            else
            {
                project.SaveProject(ID);
                return 1;
            }
        }
        public (string pName, string pInfo, string cName, string cInfo, string remark, DateTime start, DateTime end) GetProject(int ID)
        {
            Projects project = new Projects();
            return project.GetProject(ID);
        }
    }
}
