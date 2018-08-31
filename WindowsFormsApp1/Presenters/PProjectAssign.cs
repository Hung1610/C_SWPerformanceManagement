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
        //public PProjectAssign(IProjectAssign view) => this.vAssign = view;
        // This list contains more data than the other lists. For use in creating from listview and methods interacting with SQL database.
        public BindingList<ProjectAssignData> assignList()
        {
            ProjectAssign project = new ProjectAssign();
            return project.assignList();
        }
    }
}
