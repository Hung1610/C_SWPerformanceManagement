using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SWInternPerformance.Presenters
{
    interface ILogin
    {
        string Password { get; }
        string Username { get; }
    }
}
