using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Presenters
{
    class PProjects
    {
        private IProjects vProject;
        public PProjects(IProjects view) => this.vProject = view;
        public List<ProjectAssignData> assignList()
        {
            Projects project = new Projects();
            return project.assignList();
        }
        public int listSearch(string pName, List<ProjectAssignData> list)
        {
            foreach (ProjectAssignData project in list)
            {
                if (project.ProjectName == pName)
                    return project.ProjectID;
            }
            return -1;
        }
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

    }
}
