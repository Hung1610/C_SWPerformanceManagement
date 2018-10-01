using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Presenters
{
    interface ISkillManage
    {
        int SkillListID { get; }
        DateTime StartDate { get; }
        int Del { get; }
        string Remark { get; }
    }
}
