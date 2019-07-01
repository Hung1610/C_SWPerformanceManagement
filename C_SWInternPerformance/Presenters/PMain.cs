using C_SWInternPerformance.Data;
using C_SWInternPerformance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Presenters
{
    class PMain:BasePresenter
    {
        private IMain vMain;
        public PMain(IMain view) => this.vMain = view;

        // Get a list of performance reports.
        public BindingList<PerformanceData> GetPerformances()
        {
            Main main = new Main();
            return main.GetPerfList();
        }

        // Get user rights.
        public string GetRights()
        {
            Main main = new Main();
            main.UserID = vMain.UserID;
            return main.GetRights();
        }
    }
}
