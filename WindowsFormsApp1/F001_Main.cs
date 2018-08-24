using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class F001_Main : Form
    {
        
        public F001_Main()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] row = { "lol", "fux", "ayy", "ok" };
            var listViewItem = new ListViewItem(row);
            employeeList.Items.Add(listViewItem);
        }
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

        private void WorkReportButton_Click(object sender, EventArgs e)
        {
            F100_WorkingReport f100= new F100_WorkingReport();
            f100.Show();
        }

        private void updateSkillButton_Click(object sender, EventArgs e)
        {

        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            F201_ProjectAssign f201 = new F201_ProjectAssign();
            f201.Show();
        }

    }
}
