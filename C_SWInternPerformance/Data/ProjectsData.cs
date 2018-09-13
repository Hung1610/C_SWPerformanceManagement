using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Data
{
    // A simpler version of the ProjectAssignData object. Mostly used in comboboxes.
    public class ProjectsData
    {
        public ProjectsData(int ID, string Name)
        {
            this.ProjectID = ID;
            this.ProjectName = Name;
        }
        public ProjectsData This
        {
            get
            {
                return this;
            }
        }
        public ProjectsData() { }
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
    }
}
