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
    public abstract class BasePresenter
    {

        // A simpler list for the combobox.
        public BindingList<ProjectsData> GetProjects()
        {
            BaseModel project = new ProjectAssign();
            return project.ProjectList();
        }
    }
}
