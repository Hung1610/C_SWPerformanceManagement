using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Data
{
    // Object being used to create a multitude of lists. May not be efficient. Check again later.
    public class ProjectAssignData
    {
        public int ProjectAssignID { get; set; }
        public int ProjectID { get; set; }
        public int EmployeeID { get; set; }
        public int RoleID { get; set; }
        public string ProjectName { get; set; }
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Remark { get; set; }
        public int compare (ProjectAssignData b)
        {
            if (this.ProjectName != b.ProjectName)
                return 0;
            if (this.EmployeeName != b.EmployeeName)
                return 0;
            if (this.Role != b.Role)
                return 0;
            if (this.StartDate != b.StartDate)
                return 0;
            if (this.EndDate != b.EndDate)
                return 0;
            if (this.Remark != b.Remark)
                return 0;
                
            return 1;
        }
    }
}
