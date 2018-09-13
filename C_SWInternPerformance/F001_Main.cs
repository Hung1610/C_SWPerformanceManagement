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

namespace C_SWInternPerformance
{
    public partial class F001_Main : Form
    {
        // ID taken from Login for use in this and other forms.
        int UserID;
        // Close all currently opened forms when this form is closed, then re-open Login.
        BindingList<ProjectsData> projects;
        BindingList<ProjectAssignData> assignList;
        private void FrmData_FormClosed(object sender, FormClosedEventArgs e)
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
            projects = pAssign.GetProjects();
            projectBox.DataSource = projects;
            projectBox.DisplayMember = "ProjectName";
            timeBox.DataSource =new string[] { "last day", "last week","last month","last year","custom" };
        }

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
            }
        }

        // Initialize Data for the list view.
        private void Form1_Load(object sender, EventArgs e)
        {
            assignList = pAssign.AssignList();
            mainData.DataSource = assignList;
            mainData.Columns["ProjectID"].Visible = false;
            mainData.Columns["EmployeeID"].Visible = false;
            mainData.Columns["RoleID"].Visible = false;
            mainData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Open Employee form.
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
            f300.Show();
        }
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
            F300_Employee f300 = new F300_Employee();
            f300.Show();
        }

        // Open Project form.
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
            f200.Show();
        }
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
            F200_Project f200 = new F200_Project();
            f200.Show();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            f100.Show();
        }

        private void UpdateSkillButton_Click(object sender, EventArgs e)
        {

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
    }
}
