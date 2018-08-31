using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Presenters
{
    interface IProjectAssign
    {
        int ProjectID { get; }
        int EmployeeID { get; }
        int ProjectRoleID { get; }
        string Remark { get; }
        string ProjectName { get; }
        string EmployeeName { get; }
        string Role { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; } 
    }
}
