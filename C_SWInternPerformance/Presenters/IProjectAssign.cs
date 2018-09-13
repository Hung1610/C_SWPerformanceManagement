using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Presenters
{
    interface IProjectAssign
    {
        int ProjectAssignID { get; }
        int ProjectID { get; }
        int EmployeeID { get; }
        int ProjectRoleID { get; }
        string ProjectName { get; }
        string EmployeeName { get; }
        string Role { get; }
        string Remark { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; } 
    }
}
