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
        public BindingList<PerformanceData> GetPerformances()
        {
            Main main = new Main();
            return main.GetPerfList();
        }
    }
}
