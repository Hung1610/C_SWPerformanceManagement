using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Presenters
{
    interface ISkillEdit
    {
        int SkillEditID { get; }
        string SkillName { get; }
        string SkillType { get; }
        int DelEdit { get; }
        string RemarkEdit { get; }
    }
}
