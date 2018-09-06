using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Presenters;

namespace WindowsFormsApp1
{
    public partial class F001_Main : Form
    {
        // ID taken from Login for use in this and other forms.
        int UserID;
        // Close all currently opened forms when this form is closed, then re-open Login.
        private void frmData_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
                f.Close();
            F000_Login login = new F000_Login();
            login.Show();
        }
        // Declare presenters.
        PProjectAssign pAssign = new PProjectAssign();

        // Initialize components and some data.
        public F001_Main(string user,int ID)
        {
            InitializeComponent();
            Console.WriteLine(ID);
            UserID = ID;
            userLabel.Text = user;
            BindingList<ProjectsData> projects = pAssign.getPList();
            projectBox.DataSource = projects;
            projectBox.DisplayMember = "ProjectName";
            timeBox.DataSource =new string[] { "last day", "last week","last month","last year","custom" };
        }

        // Handles the timebox selection.
        private void timeBox_SelectedIndexChanged(object sender, EventArgs e)
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
            }
        }

        // Initialize Data for the list view.
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] row = { "lol", "fux", "ayy", "ok" };
            var listViewItem = new ListViewItem(row);
            employeeList.Items.Add(listViewItem);
        }

        // Open Employee form.
        private void button3_Click(object sender, EventArgs e)
        {
            F300_Employee f300 = new F300_Employee();
            f300.Show();
        }
        private void updateEmployeeButton_Click(object sender, EventArgs e)
        {
            F300_Employee f300 = new F300_Employee();
            f300.Show();
        }

        // Open Project form.
        private void button2_Click(object sender, EventArgs e)
        {
            F200_Project f200 = new F200_Project();
            f200.Show();
        }
        private void updateProjectButton_Click(object sender, EventArgs e)
        {
            F200_Project f200 = new F200_Project();
            f200.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Open Work Report form.
        private void WorkReportButton_Click(object sender, EventArgs e)
        {
            F100_WorkingReport f100= new F100_WorkingReport(UserID);
            f100.Show();
        }

        private void updateSkillButton_Click(object sender, EventArgs e)
        {

        }
        
        // Open Project Assign form.
        private void assignButton_Click(object sender, EventArgs e)
        {
            F201_ProjectAssign f201 = new F201_ProjectAssign();
            f201.Show();
        }
    }
}
