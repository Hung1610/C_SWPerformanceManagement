﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_SWInternPerformance.Data;
using C_SWInternPerformance.Models;
using C_SWInternPerformance.Presenters;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;

namespace C_SWInternPerformance
{
    public partial class F001_Main : MaterialForm,IMain
    {
        // Message box strings.
        string RowSelectMessage = "Please select a row from the table.";

        // Permissions string.
        string Permissions;
        // UserID.
        int uID;

        // Default size.
        int defaultHeight;
        int defaultWidth;

        // Declare presenters.
        PMain pMain;

        // Lists to store data.
        BindingList<ProjectsData> projects;
        BindingList<PerformanceData> performances;

        // Initialize components and some data.
        public F001_Main(int ID)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.SoftWorldICO;
            // Create a material theme manager and add the form to manage (this).
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Configure color schema.
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey900, Primary.Grey900,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            uID = ID;
            Console.WriteLine(ID);
            pMain = new PMain(this);
            userLabel.Text = "Welcome, " + pMain.GetUser(ID);
            defaultHeight = this.Height;
            defaultWidth = this.Width;
            // Populate the lists.
            projects = pMain.GetProjects();
            performances = pMain.GetPerformances();
            //
            projectBox.DataSource = projects;
            projectBox.DisplayMember = "ProjectName";
            timeBox.DataSource =new string[] {"all time", "last day", "last week","last month","last year","custom" };
        }

        // Initialize Data for the list view.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Get a string containing user rights.
            Permissions = pMain.GetRights();
            if (!Permissions.Contains("r1"))
                assignButton.Enabled = false;

            // Hiding backstage columns.
            mainData.Columns["PerformanceID"].Visible = false;
            mainData.Columns["ProjectID"].Visible = false;
            mainData.Columns["EmployeeID"].Visible = false;
            // Setting autosize mode.
            mainData.Columns["ProjectName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            mainData.Columns["EmployeeName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            mainData.Columns["WorkingDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            mainData.Columns["WorkingHour"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            mainData.Columns["WorkingName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            foreach (DataGridViewColumn column in mainData.Columns)
                column.SortMode = DataGridViewColumnSortMode.Automatic;
        }

        // Gives the form Shadow Drop.
        #region SHADOWING for Borderless Forms.

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
        }
        #endregion

        // This region implements IMain elements.
        #region IMain ELEMENTS.
        public int UserID
        {
            get
            {
                return uID;
            }
        }

        public int ProjectID
        {
            get
            {
                var value = mainData.CurrentRow.Cells["ProjectID"].Value;
                return (int)value;
            }
        }
        public int EmployeeID
        {
            get
            {
                var value = mainData.CurrentRow.Cells["EmployeeID"].Value;
                return (int)value;
            }
        }
        #endregion

        // Fancy color when selecting rows.
        private void mainData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                for (int i = 0; i < mainData.Rows[e.RowIndex].Cells.Count; i++)
                {
                    mainData[i, e.RowIndex].Style.BackColor = Color.Yellow;
                }
            }
        }
        private void mainData_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < mainData.Rows[e.RowIndex].Cells.Count; i++)
            {
                mainData[i, e.RowIndex].Style.BackColor = Color.Empty;
            }
        }
        private void mainData_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        // Refresh the form.
        private void RefreshForm()
        {
            pMain = new PMain(this);
            userLabel.Text = "Welcome, " + pMain.GetUser(UserID);
            Permissions = pMain.GetRights();
            if (!Permissions.Contains("r1"))
                assignButton.Enabled = false;
            else
                assignButton.Enabled = true;
            projectBox.SelectedIndex = 0;
            timeBox.SelectedIndex = 0;
            projects = pMain.GetProjects();
            performances = pMain.GetPerformances();
            projectBox.SelectedIndex = 0;
            timeBox.SelectedIndex = 0;
            projectBox.DataSource = projects;
            mainData.DataSource = new BindingList<PerformanceData>(performances.OrderBy(x => x.ProjectName).ToList());
        }

        // Listen to refresh event from other forms.
        private void RefreshRequest(object sender, EventArgs e)
        {
            this.RefreshForm();
        }

        // Current filtered mainData DataSource.
        BindingList<PerformanceData> currentList;
        // Handles the timebox selection.
        private void TimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeBox.Text!= ("custom"))
            {
                fromDatePick.Enabled = false;
                toDatePick.Enabled = false;
            }
            else
            {
                fromDatePick.Enabled = true;
                toDatePick.Enabled = true;
                BindingList<PerformanceData> filteredList = new BindingList<PerformanceData>(currentList.Where(o => o.WorkingDate > fromDatePick.Value.AddDays(-1) && o.WorkingDate <= toDatePick.Value).ToList());
                mainData.DataSource = new BindingList<PerformanceData>(filteredList.OrderBy(x => x.ProjectID).ToList());
            }
            if(timeBox.Text == "all time")
            {
                mainData.DataSource = currentList;
            }
            if (timeBox.Text == "last year")
            {
                BindingList<PerformanceData> filteredList = new BindingList<PerformanceData>(currentList.Where(o => o.WorkingDate.Year.Equals(DateTime.Now.Year) == true).ToList());
                mainData.DataSource = new BindingList<PerformanceData>(filteredList.OrderBy(x => x.ProjectID).ToList());
            }
            if (timeBox.Text == "last month")
            {
                BindingList<PerformanceData> filteredList = new BindingList<PerformanceData>(currentList.Where(o => o.WorkingDate.Month.Equals(DateTime.Now.Month) == true).ToList());
                mainData.DataSource = new BindingList<PerformanceData>(filteredList.OrderBy(x => x.ProjectID).ToList());
            }
            if (timeBox.Text == "last week")
            {
                DateTime startOfWeek = DateTime.Today.AddDays(-1 * (int)(DateTime.Today.DayOfWeek));
                DateTime endOfWeek = startOfWeek.AddDays(7);
                BindingList<PerformanceData> filteredList = new BindingList<PerformanceData>(currentList.Where(o => o.WorkingDate >= startOfWeek && o.WorkingDate <= endOfWeek).ToList());
                mainData.DataSource = new BindingList<PerformanceData>(filteredList.OrderBy(x => x.ProjectID).ToList());
            }
            if (timeBox.Text == "last day")
            {
                BindingList<PerformanceData> filteredList = new BindingList<PerformanceData>(currentList.Where(o => o.WorkingDate.Day.Equals(DateTime.Now.Day) == true).ToList());
                mainData.DataSource = new BindingList<PerformanceData>(filteredList.OrderBy(x => x.ProjectID).ToList());
            }
        }
        // Handle custom date selection.
        private void fromDatePick_ValueChanged(object sender, EventArgs e)
        {
            BindingList<PerformanceData> filteredList = new BindingList<PerformanceData>(currentList.Where(o => o.WorkingDate > fromDatePick.Value.AddDays(-1) && o.WorkingDate <= toDatePick.Value).ToList());
            mainData.DataSource = new BindingList<PerformanceData>(filteredList.OrderBy(x => x.ProjectID).ToList());
        }

        private void toDatePick_ValueChanged(object sender, EventArgs e)
        {
            BindingList<PerformanceData> filteredList = new BindingList<PerformanceData>(currentList.Where(o => o.WorkingDate > fromDatePick.Value.AddDays(-1) && o.WorkingDate <= toDatePick.Value).ToList());
            mainData.DataSource = new BindingList<PerformanceData>(filteredList.OrderBy(x => x.ProjectID).ToList());
        }

        // Filter DataGridView based on Project combobox selection. Reset Timebox back to "all time" with each selection.
        private void projectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectsData current = projectBox.SelectedItem as ProjectsData;
            if (current.ProjectID == -1)
            {
                if(timeBox.Items.Count > 1)
                    timeBox.SelectedIndex = 0;
                mainData.DataSource = new BindingList<PerformanceData>(performances.OrderBy(x => x.ProjectName).ToList());
                currentList = (BindingList<PerformanceData>)mainData.DataSource;
            }
            else
            {
                if(timeBox.Items.Count > 1)
                    timeBox.SelectedIndex = 0;
                BindingList<PerformanceData> filteredList = new BindingList<PerformanceData>(performances.Where(o => o.ProjectID.Equals(current.ProjectID) == true).ToList());
                mainData.DataSource = new BindingList<PerformanceData>(filteredList.OrderBy(x => x.EmployeeID).ToList());
                currentList = (BindingList<PerformanceData>)mainData.DataSource;
            }
        }

        // Open Employee form.
        // To Create.
        private void Button3_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is F300_Employee)
                {
                    f.Focus();
                    return;
                }
            }
            F300_Employee f300 = new F300_Employee();
            f300.EmployeeRefresh += RefreshRequest;
            f300.Show();
        }
        // To Edit.
        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is F300_Employee)
                {
                    f.Focus();
                    return;
                }
            }
            if (mainData.CurrentRow != null)
            {
                F300_Employee f300 = new F300_Employee(this.EmployeeID);
                f300.EmployeeRefresh += RefreshRequest;
                f300.Show();
            }
            else
            {
                MessageBox.Show(RowSelectMessage);
            }
        }

        // Open Project form.
        // To Create.
        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is F200_Project)
                {
                    f.Focus();
                    return;
                }
            }
            F200_Project f200 = new F200_Project();
            f200.ProjectRefresh += RefreshRequest;
            f200.Show();
        }
        // To Edit.
        private void UpdateProjectButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is F200_Project)
                {
                    f.Focus();
                    return;
                }
            }
            if (mainData.CurrentRow != null)
            {
                F200_Project f200 = new F200_Project(this.ProjectID);
                f200.ProjectRefresh += RefreshRequest;
                f200.Show();
            }
            else
            {
                MessageBox.Show(RowSelectMessage);
            }
        }

        // Open Work Report form.
        private void WorkReportButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is F100_WorkingReport)
                {
                    f.Focus();
                    return;
                }
            }
            F100_WorkingReport f100= new F100_WorkingReport(UserID);
            f100.ReportRefresh += RefreshRequest;
            f100.Show();
        }

        // Open Skill Update form.
        private void UpdateSkillButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is F500_SkillManage)
                {
                    f.Focus();
                    return;
                }
            }
            F500_SkillManage f500 = new F500_SkillManage(UserID);
            f500.Show();
        }
        
        // Open Project Assign form.
        private void AssignButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is F201_ProjectAssign)
                {
                    f.Focus();
                    return;
                }
            }
            F201_ProjectAssign f201 = new F201_ProjectAssign();
            f201.Show();
        }

        // Open Profile Edit form.
        private void profileButton_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is F301_Profile)
                {
                    f.Focus();
                    return;
                }
            }
            F301_Profile f301 = new F301_Profile(UserID);
            f301.Show();
        }



        // Hide the side panel when clicking on the form.
        private void F001_Main_Click(object sender, EventArgs e)
        {
            if (panelSide.Visible)
            {
                slideButton.BackColor = Color.FromArgb(38, 50, 56);
                slideButton.FlatAppearance.BorderColor = Color.FromArgb(38, 50, 56);
                panelSide.Visible = false;
            }
        }

        // Side Panel menu button.
        private void slideButton_Click(object sender, EventArgs e)
        {
            if (!panelSide.Visible)
            {
                slideButton.BackColor = Color.FromArgb(33, 33, 33);
                slideButton.FlatAppearance.BorderColor = Color.FromArgb(33, 33, 33);
                panelSide.Visible = true;
            }
            else
            {
                slideButton.BackColor = Color.FromArgb(38, 50, 56);
                slideButton.FlatAppearance.BorderColor = Color.FromArgb(38, 50, 56);
                panelSide.Visible = false;
            }
        }
        
        // Close all currently opened forms when this form is closed, then re-open Login.
        private void FrmData_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
                f.Close();
            F000_Login login = new F000_Login();
            login.Show();
            login.Focus();
        }
    }
}
