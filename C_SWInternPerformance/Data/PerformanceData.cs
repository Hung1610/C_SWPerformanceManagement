using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Data
{
    class PerformanceData
    {
        public int PerformanceID { get; set; }
        public int ProjectID { get; set; }
        public int EmployeeID { get; set; }
        public string ProjectName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime WorkingDate { get; set; }
        public Double WorkingHour { get; set; }
        public string WorkingName {
            get
            {
                return EmployeeID.ToString() + "_" + ProjectName + "_" + WorkingDate.ToString("dd/MM/yyyy");
            }
        }
        public string WorkingDetail { get; set; }
    }
}
