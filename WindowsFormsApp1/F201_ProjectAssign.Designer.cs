namespace WindowsFormsApp1
{
    partial class F201_ProjectAssign
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
            this.projectName = new System.Windows.Forms.Label();
            this.projectNameBox = new System.Windows.Forms.ComboBox();
            this.projectAssignList = new System.Windows.Forms.ListView();
            this.employeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.Location = new System.Drawing.Point(82, 45);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(139, 26);
            this.projectName.TabIndex = 0;
            this.projectName.Text = "ProjectName";
            // 
            // projectNameBox
            // 
            this.projectNameBox.FormattingEnabled = true;
            this.projectNameBox.Location = new System.Drawing.Point(298, 45);
            this.projectNameBox.Name = "projectNameBox";
            this.projectNameBox.Size = new System.Drawing.Size(250, 24);
            this.projectNameBox.TabIndex = 1;
            // 
            // projectAssignList
            // 
            this.projectAssignList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeName,
            this.role,
            this.startDate,
            this.endDate,
            this.remark});
            this.projectAssignList.Location = new System.Drawing.Point(1, 131);
            this.projectAssignList.Name = "projectAssignList";
            this.projectAssignList.Size = new System.Drawing.Size(800, 221);
            this.projectAssignList.TabIndex = 2;
            this.projectAssignList.UseCompatibleStateImageBehavior = false;
            this.projectAssignList.View = System.Windows.Forms.View.Details;
            // 
            // employeeName
            // 
            this.employeeName.Text = "Employee Name";
            this.employeeName.Width = 184;
            // 
            // role
            // 
            this.role.Text = "Role";
            this.role.Width = 140;
            // 
            // startDate
            // 
            this.startDate.Text = "StartDate";
            this.startDate.Width = 108;
            // 
            // endDate
            // 
            this.endDate.Text = "EndDate";
            this.endDate.Width = 108;
            // 
            // remark
            // 
            this.remark.Text = "Remark";
            this.remark.Width = 240;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 395);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 43);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(653, 395);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(135, 43);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.close_Click);
            // 
            // F201_ProjectAssign
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.projectNameBox);
            this.Controls.Add(this.projectAssignList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F201_ProjectAssign";
            this.Text = "F201_ProjectAssign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.ComboBox projectNameBox;
        private System.Windows.Forms.ListView projectAssignList;
        private System.Windows.Forms.ColumnHeader employeeName;
        private System.Windows.Forms.ColumnHeader role;
        private System.Windows.Forms.ColumnHeader startDate;
        private System.Windows.Forms.ColumnHeader endDate;
        private System.Windows.Forms.ColumnHeader remark;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
    }
}