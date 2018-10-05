namespace C_SWInternPerformance
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F001_Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.workReportButton = new System.Windows.Forms.Button();
            this.imageListButtons = new System.Windows.Forms.ImageList(this.components);
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
            this.mainData = new System.Windows.Forms.DataGridView();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.flowLayoutMenuButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.userLabel = new System.Windows.Forms.Button();
            this.imageListAvatar = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.flowLayoutMenuButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // workReportButton
            // 
            this.workReportButton.BackColor = System.Drawing.Color.White;
            this.workReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.workReportButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.workReportButton.FlatAppearance.BorderSize = 2;
            this.workReportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.workReportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.workReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workReportButton.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workReportButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.workReportButton.ImageKey = "workreport.png";
            this.workReportButton.ImageList = this.imageListButtons;
            this.workReportButton.Location = new System.Drawing.Point(2, 2);
            this.workReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.workReportButton.Name = "workReportButton";
            this.workReportButton.Size = new System.Drawing.Size(178, 86);
            this.workReportButton.TabIndex = 0;
            this.workReportButton.Text = "Working Report";
            this.workReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.workReportButton.UseVisualStyleBackColor = false;
            this.workReportButton.Click += new System.EventHandler(this.WorkReportButton_Click);
            // 
            // imageListButtons
            // 
            this.imageListButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtons.ImageStream")));
            this.imageListButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtons.Images.SetKeyName(0, "project-management.png");
            this.imageListButtons.Images.SetKeyName(1, "user(1).png");
            this.imageListButtons.Images.SetKeyName(2, "businessman.png");
            this.imageListButtons.Images.SetKeyName(3, "add businessman.png");
            this.imageListButtons.Images.SetKeyName(4, "workreport.png");
            this.imageListButtons.Images.SetKeyName(5, "project.png");
            this.imageListButtons.Images.SetKeyName(6, "project add.png");
            this.imageListButtons.Images.SetKeyName(7, "skills.png");
            this.imageListButtons.Images.SetKeyName(8, "technical-drawing.png");
            // 
            // addProjectButton
            // 
            this.addProjectButton.BackColor = System.Drawing.Color.White;
            this.addProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProjectButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addProjectButton.FlatAppearance.BorderSize = 2;
            this.addProjectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.addProjectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProjectButton.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProjectButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addProjectButton.ImageKey = "project add.png";
            this.addProjectButton.ImageList = this.imageListButtons;
            this.addProjectButton.Location = new System.Drawing.Point(184, 2);
            this.addProjectButton.Margin = new System.Windows.Forms.Padding(2);
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Size = new System.Drawing.Size(178, 86);
            this.addProjectButton.TabIndex = 1;
            this.addProjectButton.Text = "Add Project";
            this.addProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addProjectButton.UseVisualStyleBackColor = false;
            this.addProjectButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.White;
            this.addEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addEmployeeButton.FlatAppearance.BorderSize = 2;
            this.addEmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.addEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeButton.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addEmployeeButton.ImageKey = "add businessman.png";
            this.addEmployeeButton.ImageList = this.imageListButtons;
            this.addEmployeeButton.Location = new System.Drawing.Point(366, 2);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(178, 86);
            this.addEmployeeButton.TabIndex = 2;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // assignButton
            // 
            this.assignButton.BackColor = System.Drawing.Color.White;
            this.assignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assignButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.assignButton.FlatAppearance.BorderSize = 2;
            this.assignButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.assignButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.assignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignButton.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.assignButton.ImageKey = "project-management.png";
            this.assignButton.ImageList = this.imageListButtons;
            this.assignButton.Location = new System.Drawing.Point(548, 2);
            this.assignButton.Margin = new System.Windows.Forms.Padding(2);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(178, 86);
            this.assignButton.TabIndex = 3;
            this.assignButton.Text = "Project Assign";
            this.assignButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.assignButton.UseVisualStyleBackColor = false;
            this.assignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // updateSkillButton
            // 
            this.updateSkillButton.BackColor = System.Drawing.Color.White;
            this.updateSkillButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateSkillButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateSkillButton.FlatAppearance.BorderSize = 2;
            this.updateSkillButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.updateSkillButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.updateSkillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSkillButton.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSkillButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.updateSkillButton.ImageKey = "skills.png";
            this.updateSkillButton.ImageList = this.imageListButtons;
            this.updateSkillButton.Location = new System.Drawing.Point(2, 92);
            this.updateSkillButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateSkillButton.Name = "updateSkillButton";
            this.updateSkillButton.Size = new System.Drawing.Size(178, 86);
            this.updateSkillButton.TabIndex = 4;
            this.updateSkillButton.Text = "Update Skill";
            this.updateSkillButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateSkillButton.UseVisualStyleBackColor = false;
            this.updateSkillButton.Click += new System.EventHandler(this.UpdateSkillButton_Click);
            // 
            // updateProjectButton
            // 
            this.updateProjectButton.BackColor = System.Drawing.Color.White;
            this.updateProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateProjectButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateProjectButton.FlatAppearance.BorderSize = 2;
            this.updateProjectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.updateProjectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.updateProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateProjectButton.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProjectButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.updateProjectButton.ImageKey = "project.png";
            this.updateProjectButton.ImageList = this.imageListButtons;
            this.updateProjectButton.Location = new System.Drawing.Point(184, 92);
            this.updateProjectButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateProjectButton.Name = "updateProjectButton";
            this.updateProjectButton.Size = new System.Drawing.Size(178, 86);
            this.updateProjectButton.TabIndex = 5;
            this.updateProjectButton.Text = "Update Project";
            this.updateProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateProjectButton.UseVisualStyleBackColor = false;
            this.updateProjectButton.Click += new System.EventHandler(this.UpdateProjectButton_Click);
            // 
            // updateEmployeeButton
            // 
            this.updateEmployeeButton.BackColor = System.Drawing.Color.White;
            this.updateEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateEmployeeButton.FlatAppearance.BorderSize = 2;
            this.updateEmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.updateEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.updateEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateEmployeeButton.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployeeButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.updateEmployeeButton.ImageKey = "businessman.png";
            this.updateEmployeeButton.ImageList = this.imageListButtons;
            this.updateEmployeeButton.Location = new System.Drawing.Point(366, 92);
            this.updateEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateEmployeeButton.Name = "updateEmployeeButton";
            this.updateEmployeeButton.Size = new System.Drawing.Size(178, 86);
            this.updateEmployeeButton.TabIndex = 6;
            this.updateEmployeeButton.Text = "Update Employee";
            this.updateEmployeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateEmployeeButton.UseVisualStyleBackColor = false;
            this.updateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.White;
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.profileButton.FlatAppearance.BorderSize = 2;
            this.profileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.profileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.profileButton.ImageKey = "user(1).png";
            this.profileButton.ImageList = this.imageListButtons;
            this.profileButton.Location = new System.Drawing.Point(548, 92);
            this.profileButton.Margin = new System.Windows.Forms.Padding(2);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(178, 86);
            this.profileButton.TabIndex = 7;
            this.profileButton.Text = "Change My Profile";
            this.profileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time View";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "To";
            // 
            // projectBox
            // 
            this.projectBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.projectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectBox.FormattingEnabled = true;
            this.projectBox.Location = new System.Drawing.Point(70, 280);
            this.projectBox.Margin = new System.Windows.Forms.Padding(2);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(158, 23);
            this.projectBox.TabIndex = 12;
            this.projectBox.SelectedIndexChanged += new System.EventHandler(this.projectBox_SelectedIndexChanged);
            // 
            // timeBox
            // 
            this.timeBox.BackColor = System.Drawing.Color.White;
            this.timeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.FormattingEnabled = true;
            this.timeBox.Location = new System.Drawing.Point(338, 280);
            this.timeBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(88, 23);
            this.timeBox.TabIndex = 13;
            this.timeBox.SelectedIndexChanged += new System.EventHandler(this.TimeBox_SelectedIndexChanged);
            // 
            // fromDatePick
            // 
            this.fromDatePick.Location = new System.Drawing.Point(56, 313);
            this.fromDatePick.Margin = new System.Windows.Forms.Padding(2);
            this.fromDatePick.Name = "fromDatePick";
            this.fromDatePick.Size = new System.Drawing.Size(214, 20);
            this.fromDatePick.TabIndex = 14;
            this.fromDatePick.ValueChanged += new System.EventHandler(this.fromDatePick_ValueChanged);
            // 
            // toDatePick
            // 
            this.toDatePick.Location = new System.Drawing.Point(309, 313);
            this.toDatePick.Margin = new System.Windows.Forms.Padding(2);
            this.toDatePick.Name = "toDatePick";
            this.toDatePick.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toDatePick.RightToLeftLayout = true;
            this.toDatePick.Size = new System.Drawing.Size(214, 20);
            this.toDatePick.TabIndex = 15;
            this.toDatePick.ValueChanged += new System.EventHandler(this.toDatePick_ValueChanged);
            // 
            // mainData
            // 
            this.mainData.AllowUserToAddRows = false;
            this.mainData.AllowUserToDeleteRows = false;
            this.mainData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.mainData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.mainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainData.DefaultCellStyle = dataGridViewCellStyle6;
            this.mainData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainData.Location = new System.Drawing.Point(6, 356);
            this.mainData.Margin = new System.Windows.Forms.Padding(2);
            this.mainData.Name = "mainData";
            this.mainData.RowTemplate.Height = 24;
            this.mainData.Size = new System.Drawing.Size(1039, 244);
            this.mainData.TabIndex = 18;
            this.mainData.TabStop = false;
            this.mainData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainData_CellClick);
            this.mainData.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainData_RowLeave);
            this.mainData.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.mainData_RowValidating);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::C_SWInternPerformance.Properties.Resources.softworld_logo_footer;
            this.pictureBoxLogo.Location = new System.Drawing.Point(754, 86);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(291, 207);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 17;
            this.pictureBoxLogo.TabStop = false;
            // 
            // flowLayoutMenuButtons
            // 
            this.flowLayoutMenuButtons.AutoScroll = true;
            this.flowLayoutMenuButtons.Controls.Add(this.workReportButton);
            this.flowLayoutMenuButtons.Controls.Add(this.addProjectButton);
            this.flowLayoutMenuButtons.Controls.Add(this.addEmployeeButton);
            this.flowLayoutMenuButtons.Controls.Add(this.assignButton);
            this.flowLayoutMenuButtons.Controls.Add(this.updateSkillButton);
            this.flowLayoutMenuButtons.Controls.Add(this.updateProjectButton);
            this.flowLayoutMenuButtons.Controls.Add(this.updateEmployeeButton);
            this.flowLayoutMenuButtons.Controls.Add(this.profileButton);
            this.flowLayoutMenuButtons.Location = new System.Drawing.Point(11, 86);
            this.flowLayoutMenuButtons.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutMenuButtons.Name = "flowLayoutMenuButtons";
            this.flowLayoutMenuButtons.Size = new System.Drawing.Size(739, 182);
            this.flowLayoutMenuButtons.TabIndex = 23;
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userLabel.AutoSize = true;
            this.userLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userLabel.BackColor = System.Drawing.Color.White;
            this.userLabel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.userLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.userLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.userLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.userLabel.ImageKey = "24644049.jpg";
            this.userLabel.ImageList = this.imageListAvatar;
            this.userLabel.Location = new System.Drawing.Point(903, 24);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(142, 40);
            this.userLabel.TabIndex = 24;
            this.userLabel.TabStop = false;
            this.userLabel.Text = "[UNKNOWN]";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.userLabel.UseVisualStyleBackColor = false;
            // 
            // imageListAvatar
            // 
            this.imageListAvatar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAvatar.ImageStream")));
            this.imageListAvatar.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAvatar.Images.SetKeyName(0, "24644049.jpg");
            // 
            // F001_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 606);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.flowLayoutMenuButtons);
            this.Controls.Add(this.mainData);
            this.Controls.Add(this.toDatePick);
            this.Controls.Add(this.fromDatePick);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.projectBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(744, 500);
            this.Name = "F001_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmData_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.flowLayoutMenuButtons.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DataGridView mainData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMenuButtons;
        private System.Windows.Forms.ImageList imageListButtons;
        private System.Windows.Forms.Button userLabel;
        private System.Windows.Forms.ImageList imageListAvatar;
    }
}

