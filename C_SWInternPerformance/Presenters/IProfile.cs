using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Presenters
{
    interface IProfile
    {
        int ID { get; }
        string Email { get; }
        string Password { get; }
        string Remark { get; }
        int Del { get; }
    }
}
