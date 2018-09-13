using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SWInternPerformance
{
    public abstract class CommonFormFunctions:Form
    {
        // Close button.
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
