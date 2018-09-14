namespace C_SWInternPerformance
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
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.dataProjectAssign = new System.Windows.Forms.DataGridView();
            this.ProjectCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EmployeeCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RoleCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.middleProjectBox = new System.Windows.Forms.ComboBox();
            this.middleEmpBox = new System.Windows.Forms.ComboBox();
            this.middleRoleBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataProjectAssign)).BeginInit();
            this.SuspendLayout();
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.BackColor = System.Drawing.Color.Transparent;
            this.projectName.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.projectName.Location = new System.Drawing.Point(49, 49);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(132, 25);
            this.projectName.TabIndex = 0;
            this.projectName.Text = "Project Name";
            // 
            // projectNameBox
            // 
            this.projectNameBox.FormattingEnabled = true;
            this.projectNameBox.Location = new System.Drawing.Point(187, 49);
            this.projectNameBox.Name = "projectNameBox";
            this.projectNameBox.Size = new System.Drawing.Size(250, 24);
            this.projectNameBox.TabIndex = 1;
            this.projectNameBox.SelectedIndexChanged += new System.EventHandler(this.ProjectNameBox_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(12, 395);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 43);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(653, 395);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(135, 43);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // dataProjectAssign
            // 
            this.dataProjectAssign.AllowUserToAddRows = false;
            this.dataProjectAssign.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataProjectAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProjectAssign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectCol,
            this.EmployeeCol,
            this.RoleCol});
            this.dataProjectAssign.Location = new System.Drawing.Point(12, 95);
            this.dataProjectAssign.Name = "dataProjectAssign";
            this.dataProjectAssign.RowTemplate.Height = 24;
            this.dataProjectAssign.Size = new System.Drawing.Size(776, 258);
            this.dataProjectAssign.TabIndex = 4;
            this.dataProjectAssign.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataProjectAssign_DataError);
            this.dataProjectAssign.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProjectAssign_RowEnter);
            this.dataProjectAssign.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProjectAssign_RowLeave);
            this.dataProjectAssign.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataProjectAssign_UserDeletingRow);
            // 
            // ProjectCol
            // 
            this.ProjectCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ProjectCol.HeaderText = "Project";
            this.ProjectCol.Name = "ProjectCol";
            // 
            // EmployeeCol
            // 
            this.EmployeeCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.EmployeeCol.HeaderText = "Employee";
            this.EmployeeCol.Name = "EmployeeCol";
            // 
            // RoleCol
            // 
            this.RoleCol.HeaderText = "Role";
            this.RoleCol.Name = "RoleCol";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(484, 47);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(149, 32);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "New Assignment";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(639, 47);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(149, 32);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // middleProjectBox
            // 
            this.middleProjectBox.FormattingEnabled = true;
            this.middleProjectBox.Location = new System.Drawing.Point(268, 12);
            this.middleProjectBox.Name = "middleProjectBox";
            this.middleProjectBox.Size = new System.Drawing.Size(169, 24);
            this.middleProjectBox.TabIndex = 6;
            this.middleProjectBox.Visible = false;
            // 
            // middleEmpBox
            // 
            this.middleEmpBox.FormattingEnabled = true;
            this.middleEmpBox.Location = new System.Drawing.Point(444, 12);
            this.middleEmpBox.Name = "middleEmpBox";
            this.middleEmpBox.Size = new System.Drawing.Size(169, 24);
            this.middleEmpBox.TabIndex = 6;
            this.middleEmpBox.Visible = false;
            // 
            // middleRoleBox
            // 
            this.middleRoleBox.FormattingEnabled = true;
            this.middleRoleBox.Location = new System.Drawing.Point(619, 12);
            this.middleRoleBox.Name = "middleRoleBox";
            this.middleRoleBox.Size = new System.Drawing.Size(169, 24);
            this.middleRoleBox.TabIndex = 6;
            this.middleRoleBox.Visible = false;
            // 
            // F201_ProjectAssign
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.middleRoleBox);
            this.Controls.Add(this.middleEmpBox);
            this.Controls.Add(this.middleProjectBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataProjectAssign);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.projectNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F201_ProjectAssign";
            this.Text = "F201_ProjectAssign";
            this.Load += new System.EventHandler(this.F201_ProjectAssign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProjectAssign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.ComboBox projectNameBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView dataProjectAssign;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProjectCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn RoleCol;
        private System.Windows.Forms.ComboBox middleProjectBox;
        private System.Windows.Forms.ComboBox middleEmpBox;
        private System.Windows.Forms.ComboBox middleRoleBox;
    }
}