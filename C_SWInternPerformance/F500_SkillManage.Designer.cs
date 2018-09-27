namespace C_SWInternPerformance
{
    partial class F500_SkillManage
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.closeButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitCon = new System.Windows.Forms.SplitContainer();
            this.saveSkillManageButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.datePickStart = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.checkDel = new MaterialSkin.Controls.MaterialCheckBox();
            this.richTxtRemark = new System.Windows.Forms.RichTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveSkillButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.listBoxSkill = new System.Windows.Forms.ListBox();
            this.comboBoxSkill = new System.Windows.Forms.ComboBox();
            this.panelTitle.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCon)).BeginInit();
            this.splitCon.Panel1.SuspendLayout();
            this.splitCon.Panel2.SuspendLayout();
            this.splitCon.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitle.Controls.Add(this.closeButton);
            this.panelTitle.Controls.Add(this.materialTabSelector1);
            this.panelTitle.Controls.Add(this.label5);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(625, 75);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Depth = 0;
            this.closeButton.Location = new System.Drawing.Point(597, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Primary = false;
            this.closeButton.Size = new System.Drawing.Size(21, 36);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 41);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(625, 34);
            this.materialTabSelector1.TabIndex = 5;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(625, 228);
            this.materialTabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.splitCon);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Skill Assign";
            // 
            // splitCon
            // 
            this.splitCon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCon.Location = new System.Drawing.Point(3, 3);
            this.splitCon.Name = "splitCon";
            // 
            // splitCon.Panel1
            // 
            this.splitCon.Panel1.Controls.Add(this.listBoxSkill);
            // 
            // splitCon.Panel2
            // 
            this.splitCon.Panel2.BackColor = System.Drawing.Color.White;
            this.splitCon.Panel2.Controls.Add(this.saveSkillManageButton);
            this.splitCon.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitCon.Size = new System.Drawing.Size(611, 193);
            this.splitCon.SplitterDistance = 173;
            this.splitCon.TabIndex = 3;
            this.splitCon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitCont_MouseDown);
            this.splitCon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitCont_MouseMove);
            this.splitCon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitCont_MouseUp);
            // 
            // saveSkillManageButton
            // 
            this.saveSkillManageButton.AutoSize = true;
            this.saveSkillManageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveSkillManageButton.Depth = 0;
            this.saveSkillManageButton.Location = new System.Drawing.Point(27, 179);
            this.saveSkillManageButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveSkillManageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveSkillManageButton.Name = "saveSkillManageButton";
            this.saveSkillManageButton.Primary = false;
            this.saveSkillManageButton.Size = new System.Drawing.Size(79, 36);
            this.saveSkillManageButton.TabIndex = 1;
            this.saveSkillManageButton.Text = "Save/Add";
            this.saveSkillManageButton.UseVisualStyleBackColor = true;
            this.saveSkillManageButton.Click += new System.EventHandler(this.saveSkillManageButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.richTxtRemark, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkDel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.datePickStart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSkill, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.84121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.84121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.48439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.83318F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // datePickStart
            // 
            this.datePickStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePickStart.Location = new System.Drawing.Point(155, 31);
            this.datePickStart.Name = "datePickStart";
            this.datePickStart.Size = new System.Drawing.Size(207, 20);
            this.datePickStart.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 83);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(60, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Remark";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 56);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(52, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Delete";
            // 
            // checkDel
            // 
            this.checkDel.AutoSize = true;
            this.checkDel.Depth = 0;
            this.checkDel.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkDel.Location = new System.Drawing.Point(152, 56);
            this.checkDel.Margin = new System.Windows.Forms.Padding(0);
            this.checkDel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkDel.Name = "checkDel";
            this.checkDel.Ripple = true;
            this.checkDel.Size = new System.Drawing.Size(24, 27);
            this.checkDel.TabIndex = 4;
            this.checkDel.UseVisualStyleBackColor = true;
            // 
            // richTxtRemark
            // 
            this.richTxtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtRemark.Location = new System.Drawing.Point(155, 86);
            this.richTxtRemark.Name = "richTxtRemark";
            this.richTxtRemark.Size = new System.Drawing.Size(207, 68);
            this.richTxtRemark.TabIndex = 5;
            this.richTxtRemark.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 28);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Start Date";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.saveSkillButton);
            this.tabPage2.Controls.Add(this.materialLabel8);
            this.tabPage2.Controls.Add(this.materialLabel7);
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.materialCheckBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(617, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Skill Edit";
            // 
            // saveSkillButton
            // 
            this.saveSkillButton.AutoSize = true;
            this.saveSkillButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveSkillButton.Depth = 0;
            this.saveSkillButton.Location = new System.Drawing.Point(27, 183);
            this.saveSkillButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveSkillButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveSkillButton.Name = "saveSkillButton";
            this.saveSkillButton.Primary = false;
            this.saveSkillButton.Size = new System.Drawing.Size(79, 36);
            this.saveSkillButton.TabIndex = 5;
            this.saveSkillButton.Text = "Save/Add";
            this.saveSkillButton.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(23, 95);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(52, 19);
            this.materialLabel8.TabIndex = 4;
            this.materialLabel8.Text = "Delete";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(23, 123);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(60, 19);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "Remark";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(23, 66);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(74, 19);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Skill Type";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(23, 40);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(82, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Skill Name";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(23, 16);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(38, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Skill";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(156, 124);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(388, 56);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.AutoSize = true;
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox2.Location = new System.Drawing.Point(156, 91);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(76, 30);
            this.materialCheckBox2.TabIndex = 2;
            this.materialCheckBox2.Text = "DelFlag";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(156, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Skill Update";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 228);
            this.panel1.TabIndex = 4;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(3, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(38, 19);
            this.materialLabel9.TabIndex = 2;
            this.materialLabel9.Text = "Skill";
            // 
            // listBoxSkill
            // 
            this.listBoxSkill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxSkill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSkill.FormattingEnabled = true;
            this.listBoxSkill.ItemHeight = 16;
            this.listBoxSkill.Items.AddRange(new object[] {
            "C#",
            "JAVA",
            "VB",
            "PHP",
            "JSP",
            "blahbalh"});
            this.listBoxSkill.Location = new System.Drawing.Point(0, 0);
            this.listBoxSkill.Name = "listBoxSkill";
            this.listBoxSkill.Size = new System.Drawing.Size(173, 193);
            this.listBoxSkill.TabIndex = 0;
            this.listBoxSkill.SelectedIndexChanged += new System.EventHandler(this.listBoxSkill_SelectedIndexChanged);
            // 
            // comboBoxSkill
            // 
            this.comboBoxSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSkill.Location = new System.Drawing.Point(155, 3);
            this.comboBoxSkill.Name = "comboBoxSkill";
            this.comboBoxSkill.Size = new System.Drawing.Size(207, 21);
            this.comboBoxSkill.TabIndex = 6;
            // 
            // F500_SkillManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(625, 308);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F500_SkillManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F500_SkillManage";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitCon.Panel1.ResumeLayout(false);
            this.splitCon.Panel2.ResumeLayout(false);
            this.splitCon.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCon)).EndInit();
            this.splitCon.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitCon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker datePickStart;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox checkDel;
        private System.Windows.Forms.RichTextBox richTxtRemark;
        private MaterialSkin.Controls.MaterialFlatButton saveSkillManageButton;
        private MaterialSkin.Controls.MaterialFlatButton saveSkillButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialFlatButton closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxSkill;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.ComboBox comboBoxSkill;
    }
}