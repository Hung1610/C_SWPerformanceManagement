using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SWInternPerformance
{
    public partial class F500_SkillManage : CommonForm
    {
        public F500_SkillManage()
        {
            InitializeComponent();

        }

        // Make dragging Title Panel drag the form around.
        #region Title Panel Mouse events.
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            base.PanelMove_MouseDown(sender, e);
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            base.PanelMove_MouseMove(sender, e);
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            base.PanelMove_MouseUp(sender, e);
        }
        #endregion

        // Close Button.
        private void closeButton_Click(object sender, EventArgs e)
        {
            base.Close_Click(sender, e);
            this.Close();
        }
    }
}
