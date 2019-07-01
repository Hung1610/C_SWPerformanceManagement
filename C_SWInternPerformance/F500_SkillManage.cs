using C_SWInternPerformance.Data;
using C_SWInternPerformance.Presenters;
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
    public partial class F500_SkillManage : CommonForm,ISkillManage,ISkillEdit
    {
        // Message box strings.
        string SaveConfirmTitle = "Confirm Save";
        string SaveConfirmMessage = "Save this skill assignment setting ?";
        string CreateConfirmTitle = "Confirm Create";
        string CreateConfirmMessage = "Assign a new skill ?";
        // Edit tab strings.
        string EditSaveConfirmMessage = "Save this skill setting ?";
        string EditCreateConfirmMessage = "Create this skill ?";
        // Success strings.
        string CreateSuccess = "Skill Created.";
        string SaveSuccess = "Skill Updated.";
        // Skill Duplicate Warning.
        string SkillDupWarn = "A skill with this name already exist!";
        string SkillDupWarnTitle = "Duplicate Warning!";
        // User ID gotten from main.
        int UserID;
        // Declare Presenter.
        PSkillManage PSkill;
        PSkillEdit PSkillEdit;

        AutoCompleteStringCollection AutoCompleteSource;
        // Lists to populate with data.
        BindingList<SkillData> SkillList;
        BindingList<SkillData> UserSkills;

        public F500_SkillManage(int ID)
        {
            InitializeComponent();
            UserID = ID;
            PSkill = new PSkillManage(this);
            PSkillEdit = new PSkillEdit(this);
        }
        private void F500_SkillManage_Load(object sender, EventArgs e)
        {
            // tabManage data.
            // Assign data to lists.
            SkillList = PSkill.SkillList();
            UserSkills = PSkill.GetUserSkill(UserID);
            // Assign boxes datasource.
            comboBoxSkill.DataSource = SkillList;
            comboBoxSkill.DisplayMember = "SkillName";
            comboBoxSkill.ValueMember = "SkillListID";
            listBoxSkill.DataSource = UserSkills;
            listBoxSkill.DisplayMember = "SkillName";
            listBoxSkill.ValueMember = "SkillListID";
            //
            // tabEdit data.
            AutoCompleteSource = new AutoCompleteStringCollection();
            // Strings for skillname,type suggestions.
            foreach (SkillData skill in SkillList)
            {
                UtilFormFunctions.AddUnique(comboSkillType, skill.SkillType);
                UtilFormFunctions.AddUnique(AutoCompleteSource, skill.SkillName);
            }
            // Assign data to AutoComplete.
            txtSkillName.AutoCompleteCustomSource = AutoCompleteSource;
            // Assign boxes datasource.
            listBoxSkillEdit.DataSource = SkillList;
            listBoxSkillEdit.DisplayMember = "SkillName";
            listBoxSkillEdit.ValueMember = "SkillListID";
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
        // Real time SplitContainer resizing.
        #region SplitContainer Mouse events.
        //assign this to the SplitContainer's MouseDown event
        private void splitCont_MouseDown(object sender, MouseEventArgs e)
        {
            // This disables the normal move behavior
            ((SplitContainer)sender).IsSplitterFixed = true;
        }

        //assign this to the SplitContainer's MouseUp event
        private void splitCont_MouseUp(object sender, MouseEventArgs e)
        {
            // This allows the splitter to be moved normally again
            ((SplitContainer)sender).IsSplitterFixed = false;
        }

        //assign this to the SplitContainer's MouseMove event
        private void splitCont_MouseMove(object sender, MouseEventArgs e)
        {
            // Check to make sure the splitter won't be updated by the
            // normal move behavior also
            if (((SplitContainer)sender).IsSplitterFixed)
            {
                // Make sure that the button used to move the splitter
                // is the left mouse button
                if (e.Button.Equals(MouseButtons.Left))
                {
                    // Checks to see if the splitter is aligned Vertically
                    if (((SplitContainer)sender).Orientation.Equals(Orientation.Vertical))
                    {
                        // Only move the splitter if the mouse is within
                        // the appropriate bounds
                        if (e.X > 0 && e.X < ((SplitContainer)sender).Width)
                        {
                            // Move the splitter & force a visual refresh
                            ((SplitContainer)sender).SplitterDistance = e.X;
                            ((SplitContainer)sender).Refresh();
                        }
                    }
                    // If it isn't aligned vertically then it must be
                    // horizontal
                    else
                    {
                        // Only move the splitter if the mouse is within
                        // the appropriate bounds
                        if (e.Y > 0 && e.Y < ((SplitContainer)sender).Height)
                        {
                            // Move the splitter & force a visual refresh
                            ((SplitContainer)sender).SplitterDistance = e.Y;
                            ((SplitContainer)sender).Refresh();
                        }
                    }
                }
                // If a button other than left is pressed or no button
                // at all
                else
                {
                    // This allows the splitter to be moved normally again
                    ((SplitContainer)sender).IsSplitterFixed = false;
                }
            }
        }
        #endregion


        // Implements Interface elements.
        #region ISkillManage ELEMENTS.
        public int SkillListID
        {
            get
            {
                SkillData current = (SkillData)comboBoxSkill.SelectedItem;
                return current.SkillListID;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return datePickStart.Value;
            }
        }
        public int Del
        {
            get
            {
                if (checkDel.Checked)
                    return 1;
                else return 0;
            }
        }
        public string Remark
        {
            get
            {
                return richTxtRemark.Text;
            }
        }
        #endregion

        #region ISkillEdit ELEMENTS.
        public int SkillEditID {
            get
            {
                SkillData skill = (SkillData)listBoxSkillEdit.SelectedItem;
                return skill.SkillListID;
            }
        }
        public string SkillName
        {
            get
            {
                return txtSkillName.Text;
            }
        }
        public string SkillType
        {
            get
            {
                return comboSkillType.Text;
            }
        }
        public int DelEdit
        {
            get
            {
                if (checkSkillDel.Checked)
                    return 1;
                else return 0;
            }
        }
        public string RemarkEdit
        {
            get
            {
                return richTxtSkillRemark.Text;
            }
        }
        #endregion

        // Refresh Form.
        public void RefreshForm()
        {
            comboSkillType.Items.Clear();
            AutoCompleteSource.Clear();
            // Re-get data.
            UserSkills = PSkill.GetUserSkill(UserID);
            SkillList = PSkill.SkillList();
            foreach (SkillData skill in SkillList)
            {
                UtilFormFunctions.AddUnique(comboSkillType, skill.SkillType);
                UtilFormFunctions.AddUnique(AutoCompleteSource, skill.SkillName);
            }

            // Assign data.
            txtSkillName.AutoCompleteCustomSource = AutoCompleteSource;
            listBoxSkill.DataSource = UserSkills;
            listBoxSkillEdit.DataSource = SkillList;
        }

        // Handle listbox selection. tabManage.
        private void listBoxSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillData current = (SkillData) listBoxSkill.SelectedItem;
            comboBoxSkill.SelectedValue = current.SkillListID;
            datePickStart.Value = current.startDate;
            if (current.Del == 0)
                checkDel.Checked = false;
            else checkDel.Checked = true;
            richTxtRemark.Text = current.Remark;
        }

        // Handle listbox selection. tabEdit.
        private void listBoxSkillEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SkillData current = (SkillData)listBoxSkillEdit.SelectedItem;
            txtSkillName.Text = current.SkillName;
            richTxtSkillRemark.Text = current.Remark;
            comboSkillType.Text = current.SkillType;
        }

        // Save/Add button. Manage.
        private void saveSkillManageButton_Click(object sender, EventArgs e)
        {
            string title;
            string message;
            bool edit = false;
            if (UtilFormFunctions.BoxContain(listBoxSkill, comboBoxSkill.Text))
                edit = true;
            if (edit)
            {
                title = SaveConfirmTitle;
                message = SaveConfirmMessage;
            }
            else
            {
                title = CreateConfirmTitle;
                message = CreateConfirmMessage;
            }
            DialogResult result = MessageBox.Show(message,
                                                    title,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (edit)
                {
                    PSkill.SaveSkillAssign(UserID);
                    MessageBox.Show(SaveSuccess);
                }
                else
                {
                    PSkill.SkillAssign(UserID);
                    MessageBox.Show(CreateSuccess);
                }
                RefreshForm();
            }
        }

        // Save Button. Skill Edit.
        private void saveSkillButton_Click(object sender, EventArgs e)
        {
            string title = SaveConfirmTitle;
            string message = EditSaveConfirmMessage;
            DialogResult result = MessageBox.Show(message,
                                                    title,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PSkillEdit.SaveSkill();
                MessageBox.Show(SaveSuccess);
                RefreshForm();
            }
        }

        // Add Button. Skill Edit.
        private void addSkillButton_Click(object sender, EventArgs e)
        {

            string title = CreateConfirmTitle;
            string message = EditCreateConfirmMessage;
            if (UtilFormFunctions.BoxContain(listBoxSkillEdit, txtSkillName.Text))
            {
                MessageBox.Show(SkillDupWarn, SkillDupWarnTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(message,
                                                    title,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PSkillEdit.AddSkill();
                MessageBox.Show(CreateSuccess);
                RefreshForm();
            }
        }

        // Close Button.
        private void closeButton_Click(object sender, EventArgs e)
        {
            base.Close_Click(sender, e);
            this.Close();
        }

    }
}
