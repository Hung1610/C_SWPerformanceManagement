using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Presenters
{
    interface IMain
    {
        int UserID { get; }
        int ProjectID { get; }
        int EmployeeID { get; }
    }
}
