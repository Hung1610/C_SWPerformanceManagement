using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Presenters
{
    interface IEmployee
    {
        int EmployeeID { get; }
        string EmployeeName { get; }
        int PositionID { get; }
        int BranchID { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        string Email { get; }
        string Mobile { get; }
        string Address { get; }
        DateTime Birthday { get; }
        int LevelID { get; }
        string Desire { get; }
        int Del { get; }
        string Remark { get; }
    }
}
