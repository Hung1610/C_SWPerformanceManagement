using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Presenters
{
    class PProjectAssign
    {
        private IProjectAssign vAssign;
        public PProjectAssign(IProjectAssign view) => this.vAssign = view;
        public PProjectAssign() { }
        ///
        // This list contains more data than the other lists using the same object. For use in constructing from listview and methods interacting with SQL database.
        public BindingList<ProjectAssignData> assignList()
        {
            ProjectAssign project = new ProjectAssign();
            return project.assignList();
        }
        // A simpler list for the combobox.
        public BindingList<ProjectsData> getPList()
        {
            ProjectAssign project = new ProjectAssign();
            return project.getPList();
        }
    }
}
