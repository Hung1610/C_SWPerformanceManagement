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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.projectName = new System.Windows.Forms.Label();
            this.projectNameBox = new System.Windows.Forms.ComboBox();
            this.dataProjectAssign = new System.Windows.Forms.DataGridView();
            this.middleProjectBox = new System.Windows.Forms.ComboBox();
            this.middleEmpBox = new System.Windows.Forms.ComboBox();
            this.middleRoleBox = new System.Windows.Forms.ComboBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.closeButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.saveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ProjectCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EmployeeCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RoleCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataProjectAssign)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.BackColor = System.Drawing.Color.Transparent;
            this.projectName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.ForeColor = System.Drawing.Color.Black;
            this.projectName.Location = new System.Drawing.Point(12, 53);
            this.projectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(118, 25);
            this.projectName.TabIndex = 0;
            this.projectName.Text = "Project Name";
            // 
            // projectNameBox
            // 
            this.projectNameBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectNameBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.projectNameBox.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameBox.FormattingEnabled = true;
            this.projectNameBox.Location = new System.Drawing.Point(134, 57);
            this.projectNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.projectNameBox.Name = "projectNameBox";
            this.projectNameBox.Size = new System.Drawing.Size(201, 25);
            this.projectNameBox.TabIndex = 1;
            this.projectNameBox.SelectedIndexChanged += new System.EventHandler(this.ProjectNameBox_SelectedIndexChanged);
            // 
            // dataProjectAssign
            // 
            this.dataProjectAssign.AllowUserToAddRows = false;
            this.dataProjectAssign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProjectAssign.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataProjectAssign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProjectAssign.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProjectAssign.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProjectAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProjectAssign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectCol,
            this.EmployeeCol,
            this.RoleCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProjectAssign.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataProjectAssign.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataProjectAssign.Location = new System.Drawing.Point(0, 92);
            this.dataProjectAssign.Margin = new System.Windows.Forms.Padding(2);
            this.dataProjectAssign.Name = "dataProjectAssign";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProjectAssign.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataProjectAssign.RowTemplate.Height = 24;
            this.dataProjectAssign.Size = new System.Drawing.Size(744, 328);
            this.dataProjectAssign.TabIndex = 4;
            this.dataProjectAssign.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataProjectAssign_DataError);
            this.dataProjectAssign.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProjectAssign_RowEnter);
            this.dataProjectAssign.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataProjectAssign_RowValidating);
            this.dataProjectAssign.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataProjectAssign_UserDeletingRow);
            // 
            // middleProjectBox
            // 
            this.middleProjectBox.FormattingEnabled = true;
            this.middleProjectBox.Location = new System.Drawing.Point(45, 137);
            this.middleProjectBox.Margin = new System.Windows.Forms.Padding(2);
            this.middleProjectBox.Name = "middleProjectBox";
            this.middleProjectBox.Size = new System.Drawing.Size(75, 21);
            this.middleProjectBox.TabIndex = 6;
            this.middleProjectBox.Visible = false;
            // 
            // middleEmpBox
            // 
            this.middleEmpBox.FormattingEnabled = true;
            this.middleEmpBox.Location = new System.Drawing.Point(151, 137);
            this.middleEmpBox.Margin = new System.Windows.Forms.Padding(2);
            this.middleEmpBox.Name = "middleEmpBox";
            this.middleEmpBox.Size = new System.Drawing.Size(69, 21);
            this.middleEmpBox.TabIndex = 6;
            this.middleEmpBox.Visible = false;
            // 
            // middleRoleBox
            // 
            this.middleRoleBox.FormattingEnabled = true;
            this.middleRoleBox.Location = new System.Drawing.Point(248, 137);
            this.middleRoleBox.Margin = new System.Windows.Forms.Padding(2);
            this.middleRoleBox.Name = "middleRoleBox";
            this.middleRoleBox.Size = new System.Drawing.Size(78, 21);
            this.middleRoleBox.TabIndex = 6;
            this.middleRoleBox.Visible = false;
            // 
            // panelTitle
            // 
            this.panelTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitle.Controls.Add(this.closeButton);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(744, 43);
            this.panelTitle.TabIndex = 7;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Depth = 0;
            this.closeButton.Location = new System.Drawing.Point(719, -1);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Primary = false;
            this.closeButton.Size = new System.Drawing.Size(21, 36);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(11, 10);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(139, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Project Assign";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddButton.Image = global::C_SWInternPerformance.Properties.Resources.add;
            this.AddButton.Location = new System.Drawing.Point(402, 48);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(41, 36);
            this.AddButton.TabIndex = 5;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.AddButton, "New Assignment");
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RefreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RefreshButton.Image = global::C_SWInternPerformance.Properties.Resources.refresh3;
            this.RefreshButton.Location = new System.Drawing.Point(447, 48);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(44, 36);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.RefreshButton, "Refresh");
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Depth = 0;
            this.saveButton.Location = new System.Drawing.Point(350, 48);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Primary = false;
            this.saveButton.Size = new System.Drawing.Size(46, 36);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ProjectCol
            // 
            this.ProjectCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ProjectCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectCol.HeaderText = "Project";
            this.ProjectCol.Name = "ProjectCol";
            // 
            // EmployeeCol
            // 
            this.EmployeeCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.EmployeeCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeCol.HeaderText = "Employee";
            this.EmployeeCol.Name = "EmployeeCol";
            // 
            // RoleCol
            // 
            this.RoleCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.RoleCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoleCol.HeaderText = "Role";
            this.RoleCol.Name = "RoleCol";
            // 
            // F201_ProjectAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 420);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.middleRoleBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.middleEmpBox);
            this.Controls.Add(this.projectNameBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.middleProjectBox);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.dataProjectAssign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F201_ProjectAssign";
            this.Text = "Project Assign";
            this.Load += new System.EventHandler(this.F201_ProjectAssign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProjectAssign)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.ComboBox projectNameBox;
        private System.Windows.Forms.DataGridView dataProjectAssign;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ComboBox middleProjectBox;
        private System.Windows.Forms.ComboBox middleEmpBox;
        private System.Windows.Forms.ComboBox middleRoleBox;
        private System.Windows.Forms.Panel panelTitle;
        private MaterialSkin.Controls.MaterialFlatButton saveButton;
        private MaterialSkin.Controls.MaterialFlatButton closeButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProjectCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn RoleCol;
    }
}