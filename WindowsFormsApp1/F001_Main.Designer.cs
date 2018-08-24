namespace WindowsFormsApp1
{
    partial class F001_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.workReportButton = new System.Windows.Forms.Button();
            this.addProjectButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.assignButton = new System.Windows.Forms.Button();
            this.updateSkillButton = new System.Windows.Forms.Button();
            this.updateProjectButton = new System.Windows.Forms.Button();
            this.updateEmployeeButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.projectBox = new System.Windows.Forms.ComboBox();
            this.timeBox = new System.Windows.Forms.ComboBox();
            this.fromDatePick = new System.Windows.Forms.DateTimePicker();
            this.toDatePick = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.employeeList = new System.Windows.Forms.ListView();
            this.Project = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Employee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkingTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkingHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // workReportButton
            // 
            this.workReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.workReportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workReportButton.Location = new System.Drawing.Point(3, 3);
            this.workReportButton.Name = "workReportButton";
            this.workReportButton.Size = new System.Drawing.Size(217, 104);
            this.workReportButton.TabIndex = 0;
            this.workReportButton.Text = "Working Report";
            this.workReportButton.UseVisualStyleBackColor = false;
            this.workReportButton.Click += new System.EventHandler(this.WorkReportButton_Click);
            // 
            // addProjectButton
            // 
            this.addProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addProjectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProjectButton.Location = new System.Drawing.Point(226, 3);
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Size = new System.Drawing.Size(217, 104);
            this.addProjectButton.TabIndex = 1;
            this.addProjectButton.Text = "Add Project";
            this.addProjectButton.UseVisualStyleBackColor = false;
            this.addProjectButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addEmployeeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEmployeeButton.Location = new System.Drawing.Point(449, 3);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(217, 104);
            this.addEmployeeButton.TabIndex = 2;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // assignButton
            // 
            this.assignButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.assignButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignButton.Location = new System.Drawing.Point(672, 3);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(217, 104);
            this.assignButton.TabIndex = 3;
            this.assignButton.Text = "Project Assign";
            this.assignButton.UseVisualStyleBackColor = false;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // updateSkillButton
            // 
            this.updateSkillButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateSkillButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateSkillButton.Location = new System.Drawing.Point(3, 113);
            this.updateSkillButton.Name = "updateSkillButton";
            this.updateSkillButton.Size = new System.Drawing.Size(217, 104);
            this.updateSkillButton.TabIndex = 4;
            this.updateSkillButton.Text = "Update Skill";
            this.updateSkillButton.UseVisualStyleBackColor = false;
            this.updateSkillButton.Click += new System.EventHandler(this.updateSkillButton_Click);
            // 
            // updateProjectButton
            // 
            this.updateProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateProjectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateProjectButton.Location = new System.Drawing.Point(226, 113);
            this.updateProjectButton.Name = "updateProjectButton";
            this.updateProjectButton.Size = new System.Drawing.Size(217, 104);
            this.updateProjectButton.TabIndex = 5;
            this.updateProjectButton.Text = "Update Project";
            this.updateProjectButton.UseVisualStyleBackColor = false;
            this.updateProjectButton.Click += new System.EventHandler(this.updateProjectButton_Click);
            // 
            // updateEmployeeButton
            // 
            this.updateEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateEmployeeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateEmployeeButton.Location = new System.Drawing.Point(449, 113);
            this.updateEmployeeButton.Name = "updateEmployeeButton";
            this.updateEmployeeButton.Size = new System.Drawing.Size(217, 104);
            this.updateEmployeeButton.TabIndex = 6;
            this.updateEmployeeButton.Text = "Update Employee";
            this.updateEmployeeButton.UseVisualStyleBackColor = false;
            this.updateEmployeeButton.Click += new System.EventHandler(this.updateEmployeeButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.profileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileButton.Location = new System.Drawing.Point(672, 113);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(217, 104);
            this.profileButton.TabIndex = 7;
            this.profileButton.Text = "Change My Profile";
            this.profileButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "TimeView";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "To";
            // 
            // projectBox
            // 
            this.projectBox.FormattingEnabled = true;
            this.projectBox.Location = new System.Drawing.Point(110, 264);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(121, 24);
            this.projectBox.TabIndex = 12;
            // 
            // timeBox
            // 
            this.timeBox.FormattingEnabled = true;
            this.timeBox.Location = new System.Drawing.Point(311, 264);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(109, 24);
            this.timeBox.TabIndex = 12;
            // 
            // fromDatePick
            // 
            this.fromDatePick.Location = new System.Drawing.Point(478, 262);
            this.fromDatePick.Name = "fromDatePick";
            this.fromDatePick.Size = new System.Drawing.Size(200, 22);
            this.fromDatePick.TabIndex = 13;
            // 
            // toDatePick
            // 
            this.toDatePick.Location = new System.Drawing.Point(750, 262);
            this.toDatePick.Name = "toDatePick";
            this.toDatePick.Size = new System.Drawing.Size(200, 22);
            this.toDatePick.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Lime;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.profileButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.assignButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.addEmployeeButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addProjectButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.workReportButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.updateSkillButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.updateProjectButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.updateEmployeeButton, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(61, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(892, 220);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // employeeList
            // 
            this.employeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Project,
            this.Employee,
            this.WorkingTime,
            this.WorkingHour});
            this.employeeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeList.Location = new System.Drawing.Point(0, 306);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(1066, 240);
            this.employeeList.TabIndex = 15;
            this.employeeList.UseCompatibleStateImageBehavior = false;
            this.employeeList.View = System.Windows.Forms.View.Details;
            this.employeeList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Project
            // 
            this.Project.Text = "Project";
            this.Project.Width = 300;
            // 
            // Employee
            // 
            this.Employee.Text = "Employee";
            this.Employee.Width = 200;
            // 
            // WorkingTime
            // 
            this.WorkingTime.Text = "WorkingTime";
            this.WorkingTime.Width = 100;
            // 
            // WorkingHour
            // 
            this.WorkingHour.Text = "WorkingHour";
            this.WorkingHour.Width = 100;
            // 
            // F001_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1066, 546);
            this.Controls.Add(this.employeeList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toDatePick);
            this.Controls.Add(this.fromDatePick);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.projectBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "F001_Main";
            this.Text = "F001_Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button workReportButton;
        private System.Windows.Forms.Button addProjectButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button updateSkillButton;
        private System.Windows.Forms.Button updateProjectButton;
        private System.Windows.Forms.Button updateEmployeeButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox projectBox;
        private System.Windows.Forms.ComboBox timeBox;
        private System.Windows.Forms.DateTimePicker fromDatePick;
        private System.Windows.Forms.DateTimePicker toDatePick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView employeeList;
        private System.Windows.Forms.ColumnHeader Project;
        private System.Windows.Forms.ColumnHeader Employee;
        private System.Windows.Forms.ColumnHeader WorkingTime;
        private System.Windows.Forms.ColumnHeader WorkingHour;

    }
}

