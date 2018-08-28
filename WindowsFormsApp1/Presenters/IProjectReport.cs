using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Presenters
{
    interface IProjectReport
    {
        string ProjectName { get; }
        int WorkingTime { get; }
        DateTime Date { get; }
        string Remark { get; }
        int EmployeeID { get; }
        int ProjectID { get; }
    }
}
