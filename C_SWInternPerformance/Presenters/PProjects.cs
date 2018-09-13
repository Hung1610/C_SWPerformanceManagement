using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Presenters
{
    class PProjects
    {
        private IProjects vProject;
        // Get data from view.
        public PProjects(IProjects view) => this.vProject = view;

        // Create a project list.
        public List<ProjectAssignData> assignList()
        {
            Projects project = new Projects();
            return project.assignList();
        }

        // Method for searching within a List of ProjectAssignDate using ProjectName
        public int listSearch(string pName, List<ProjectAssignData> list)
        {
            foreach (ProjectAssignData project in list)
            {
                if (project.ProjectName == pName)
                    return project.ProjectID;
            }
            return -1;
        }

        // Calling addProject/saveProject method from Models to INSERT/UPDATE the database.
        public int save(int ID)
        {
            Projects project = new Projects();
            project.ProjectName = vProject.ProjectName;
            project.ProjectInfo = vProject.ProjectInfo;
            project.CustomerName = vProject.CustomerName;
            project.CustomerInfo = vProject.CustomerInfo;
            project.StartDate = vProject.StartDate;
            project.EndDate = vProject.EndDate;
            project.Remark = vProject.Remark;
            if (project.searchID(ID) < 0)
            {
                project.addProject();
                return 0;
            }
                
            else
            {
                project.saveProject(ID);
                return 1;
            }
        }
        public (string pInfo, string cName, string cInfo, string remark, DateTime start, DateTime end) getProject(int ID)
        {
            Projects project = new Projects();
            return project.getProject(ID);
        }
    }
}
