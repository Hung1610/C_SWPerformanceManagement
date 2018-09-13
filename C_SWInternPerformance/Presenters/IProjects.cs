using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Presenters
{
    interface IProjects
    {
        string ProjectName { get; }
        string ProjectInfo { get; }
        string CustomerName { get; }
        string CustomerInfo { get; }
        string Remark { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
    }
}
