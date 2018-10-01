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
            this.tabControlSkill = new MaterialSkin.Controls.MaterialTabControl();
            this.tabManage = new System.Windows.Forms.TabPage();
            this.splitCon = new System.Windows.Forms.SplitContainer();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.listBoxSkill = new System.Windows.Forms.ListBox();
            this.saveSkillManageButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.richTxtRemark = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.checkDel = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.datePickStart = new System.Windows.Forms.DateTimePicker();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxSkill = new System.Windows.Forms.ComboBox();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.splitConSkill = new System.Windows.Forms.SplitContainer();
            this.listBoxSkillEdit = new System.Windows.Forms.ListBox();
            this.saveSkillButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.comboSkillType = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSkillName = new System.Windows.Forms.TextBox();
            this.checkSkillDel = new MaterialSkin.Controls.MaterialCheckBox();
            this.richTxtSkillRemark = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.tabControlSkill.SuspendLayout();
            this.tabManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCon)).BeginInit();
            this.splitCon.Panel1.SuspendLayout();
            this.splitCon.Panel2.SuspendLayout();
            this.splitCon.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitConSkill)).BeginInit();
            this.splitConSkill.Panel1.SuspendLayout();
            this.splitConSkill.Panel2.SuspendLayout();
            this.splitConSkill.SuspendLayout();
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
            this.panelTitle.Size = new System.Drawing.Size(781, 94);
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
            this.closeButton.Location = new System.Drawing.Point(746, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Primary = false;
            this.closeButton.Size = new System.Drawing.Size(24, 36);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControlSkill;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 52);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(781, 42);
            this.materialTabSelector1.TabIndex = 5;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabControlSkill
            // 
            this.tabControlSkill.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlSkill.Controls.Add(this.tabManage);
            this.tabControlSkill.Controls.Add(this.tabEdit);
            this.tabControlSkill.Depth = 0;
            this.tabControlSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSkill.Location = new System.Drawing.Point(0, 0);
            this.tabControlSkill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlSkill.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlSkill.Name = "tabControlSkill";
            this.tabControlSkill.SelectedIndex = 0;
            this.tabControlSkill.Size = new System.Drawing.Size(781, 285);
            this.tabControlSkill.TabIndex = 3;
            // 
            // tabManage
            // 
            this.tabManage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabManage.Controls.Add(this.splitCon);
            this.tabManage.Location = new System.Drawing.Point(4, 28);
            this.tabManage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabManage.Name = "tabManage";
            this.tabManage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabManage.Size = new System.Drawing.Size(773, 253);
            this.tabManage.TabIndex = 0;
            this.tabManage.Text = "Skill Assign";
            // 
            // splitCon
            // 
            this.splitCon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCon.Location = new System.Drawing.Point(4, 4);
            this.splitCon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitCon.Name = "splitCon";
            // 
            // splitCon.Panel1
            // 
            this.splitCon.Panel1.BackColor = System.Drawing.Color.White;
            this.splitCon.Panel1.Controls.Add(this.materialLabel4);
            this.splitCon.Panel1.Controls.Add(this.listBoxSkill);
            // 
            // splitCon.Panel2
            // 
            this.splitCon.Panel2.BackColor = System.Drawing.Color.White;
            this.splitCon.Panel2.Controls.Add(this.saveSkillManageButton);
            this.splitCon.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitCon.Size = new System.Drawing.Size(765, 245);
            this.splitCon.SplitterDistance = 215;
            this.splitCon.SplitterWidth = 5;
            this.splitCon.TabIndex = 3;
            this.splitCon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitCont_MouseDown);
            this.splitCon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitCont_MouseMove);
            this.splitCon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitCont_MouseUp);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(5, 5);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(104, 24);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Your Skills:";
            // 
            // listBoxSkill
            // 
            this.listBoxSkill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxSkill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSkill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSkill.FormattingEnabled = true;
            this.listBoxSkill.ItemHeight = 20;
            this.listBoxSkill.Items.AddRange(new object[] {
            "C#",
            "JAVA",
            "VB",
            "PHP",
            "JSP",
            "blahbalh"});
            this.listBoxSkill.Location = new System.Drawing.Point(0, 5);
            this.listBoxSkill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxSkill.Name = "listBoxSkill";
            this.listBoxSkill.Size = new System.Drawing.Size(215, 240);
            this.listBoxSkill.TabIndex = 0;
            this.listBoxSkill.SelectedIndexChanged += new System.EventHandler(this.listBoxSkill_SelectedIndexChanged);
            // 
            // saveSkillManageButton
            // 
            this.saveSkillManageButton.AutoSize = true;
            this.saveSkillManageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveSkillManageButton.Depth = 0;
            this.saveSkillManageButton.Location = new System.Drawing.Point(34, 224);
            this.saveSkillManageButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.saveSkillManageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveSkillManageButton.Name = "saveSkillManageButton";
            this.saveSkillManageButton.Primary = false;
            this.saveSkillManageButton.Size = new System.Drawing.Size(96, 36);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.84121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.84121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.48439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.83318F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 196);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(4, 102);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Remark";
            // 
            // richTxtRemark
            // 
            this.richTxtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtRemark.Location = new System.Drawing.Point(194, 106);
            this.richTxtRemark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTxtRemark.Name = "richTxtRemark";
            this.richTxtRemark.Size = new System.Drawing.Size(258, 86);
            this.richTxtRemark.TabIndex = 5;
            this.richTxtRemark.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(4, 68);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Delete";
            // 
            // checkDel
            // 
            this.checkDel.AutoSize = true;
            this.checkDel.Depth = 0;
            this.checkDel.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkDel.Location = new System.Drawing.Point(190, 68);
            this.checkDel.Margin = new System.Windows.Forms.Padding(0);
            this.checkDel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkDel.Name = "checkDel";
            this.checkDel.Ripple = true;
            this.checkDel.Size = new System.Drawing.Size(26, 30);
            this.checkDel.TabIndex = 4;
            this.checkDel.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(4, 34);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(92, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Start Date";
            // 
            // datePickStart
            // 
            this.datePickStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePickStart.Location = new System.Drawing.Point(194, 38);
            this.datePickStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datePickStart.Name = "datePickStart";
            this.datePickStart.Size = new System.Drawing.Size(258, 22);
            this.datePickStart.TabIndex = 1;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(4, 0);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(46, 24);
            this.materialLabel9.TabIndex = 2;
            this.materialLabel9.Text = "Skill";
            // 
            // comboBoxSkill
            // 
            this.comboBoxSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSkill.Location = new System.Drawing.Point(194, 4);
            this.comboBoxSkill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSkill.Name = "comboBoxSkill";
            this.comboBoxSkill.Size = new System.Drawing.Size(258, 24);
            this.comboBoxSkill.TabIndex = 6;
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabEdit.Controls.Add(this.splitConSkill);
            this.tabEdit.Location = new System.Drawing.Point(4, 28);
            this.tabEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEdit.Size = new System.Drawing.Size(773, 253);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Skill Edit";
            // 
            // splitConSkill
            // 
            this.splitConSkill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitConSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitConSkill.Location = new System.Drawing.Point(4, 4);
            this.splitConSkill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitConSkill.Name = "splitConSkill";
            // 
            // splitConSkill.Panel1
            // 
            this.splitConSkill.Panel1.Controls.Add(this.listBoxSkillEdit);
            // 
            // splitConSkill.Panel2
            // 
            this.splitConSkill.Panel2.BackColor = System.Drawing.Color.White;
            this.splitConSkill.Panel2.Controls.Add(this.saveSkillButton);
            this.splitConSkill.Panel2.Controls.Add(this.materialLabel8);
            this.splitConSkill.Panel2.Controls.Add(this.materialLabel6);
            this.splitConSkill.Panel2.Controls.Add(this.materialLabel7);
            this.splitConSkill.Panel2.Controls.Add(this.comboSkillType);
            this.splitConSkill.Panel2.Controls.Add(this.materialLabel5);
            this.splitConSkill.Panel2.Controls.Add(this.txtSkillName);
            this.splitConSkill.Panel2.Controls.Add(this.checkSkillDel);
            this.splitConSkill.Panel2.Controls.Add(this.richTxtSkillRemark);
            this.splitConSkill.Size = new System.Drawing.Size(765, 245);
            this.splitConSkill.SplitterDistance = 215;
            this.splitConSkill.SplitterWidth = 5;
            this.splitConSkill.TabIndex = 6;
            // 
            // listBoxSkillEdit
            // 
            this.listBoxSkillEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxSkillEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSkillEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSkillEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSkillEdit.FormattingEnabled = true;
            this.listBoxSkillEdit.ItemHeight = 20;
            this.listBoxSkillEdit.Items.AddRange(new object[] {
            "C#",
            "JAVA",
            "VB",
            "PHP",
            "JSP",
            "blahbalh"});
            this.listBoxSkillEdit.Location = new System.Drawing.Point(0, 0);
            this.listBoxSkillEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxSkillEdit.Name = "listBoxSkillEdit";
            this.listBoxSkillEdit.Size = new System.Drawing.Size(215, 245);
            this.listBoxSkillEdit.TabIndex = 0;
            this.listBoxSkillEdit.SelectedIndexChanged += new System.EventHandler(this.listBoxSkillEdit_SelectedIndexChanged);
            // 
            // saveSkillButton
            // 
            this.saveSkillButton.AutoSize = true;
            this.saveSkillButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveSkillButton.Depth = 0;
            this.saveSkillButton.Location = new System.Drawing.Point(34, 224);
            this.saveSkillButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.saveSkillButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveSkillButton.Name = "saveSkillButton";
            this.saveSkillButton.Primary = false;
            this.saveSkillButton.Size = new System.Drawing.Size(96, 36);
            this.saveSkillButton.TabIndex = 1;
            this.saveSkillButton.Text = "Save/Add";
            this.saveSkillButton.UseVisualStyleBackColor = true;
            this.saveSkillButton.Click += new System.EventHandler(this.saveSkillButton_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(29, 90);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(63, 24);
            this.materialLabel8.TabIndex = 4;
            this.materialLabel8.Text = "Delete";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(29, 54);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(92, 24);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Skill Type";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(29, 125);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(75, 24);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "Remark";
            // 
            // comboSkillType
            // 
            this.comboSkillType.FormattingEnabled = true;
            this.comboSkillType.Location = new System.Drawing.Point(181, 55);
            this.comboSkillType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSkillType.Name = "comboSkillType";
            this.comboSkillType.Size = new System.Drawing.Size(248, 24);
            this.comboSkillType.TabIndex = 0;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(29, 21);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(102, 24);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Skill Name";
            // 
            // txtSkillName
            // 
            this.txtSkillName.Location = new System.Drawing.Point(181, 22);
            this.txtSkillName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSkillName.Name = "txtSkillName";
            this.txtSkillName.Size = new System.Drawing.Size(248, 22);
            this.txtSkillName.TabIndex = 1;
            // 
            // checkSkillDel
            // 
            this.checkSkillDel.AutoSize = true;
            this.checkSkillDel.Depth = 0;
            this.checkSkillDel.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkSkillDel.Location = new System.Drawing.Point(181, 85);
            this.checkSkillDel.Margin = new System.Windows.Forms.Padding(0);
            this.checkSkillDel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkSkillDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkSkillDel.Name = "checkSkillDel";
            this.checkSkillDel.Ripple = true;
            this.checkSkillDel.Size = new System.Drawing.Size(89, 30);
            this.checkSkillDel.TabIndex = 2;
            this.checkSkillDel.Text = "DelFlag";
            this.checkSkillDel.UseVisualStyleBackColor = true;
            // 
            // richTxtSkillRemark
            // 
            this.richTxtSkillRemark.Location = new System.Drawing.Point(181, 126);
            this.richTxtSkillRemark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTxtSkillRemark.Name = "richTxtSkillRemark";
            this.richTxtSkillRemark.Size = new System.Drawing.Size(355, 69);
            this.richTxtSkillRemark.TabIndex = 3;
            this.richTxtSkillRemark.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Skill Update";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.label5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlSkill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 285);
            this.panel1.TabIndex = 4;
            // 
            // F500_SkillManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(781, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F500_SkillManage";
            this.Text = "F500_SkillManage";
            this.Load += new System.EventHandler(this.F500_SkillManage_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.tabControlSkill.ResumeLayout(false);
            this.tabManage.ResumeLayout(false);
            this.splitCon.Panel1.ResumeLayout(false);
            this.splitCon.Panel1.PerformLayout();
            this.splitCon.Panel2.ResumeLayout(false);
            this.splitCon.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCon)).EndInit();
            this.splitCon.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.splitConSkill.Panel1.ResumeLayout(false);
            this.splitConSkill.Panel2.ResumeLayout(false);
            this.splitConSkill.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitConSkill)).EndInit();
            this.splitConSkill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTabControl tabControlSkill;
        private System.Windows.Forms.TabPage tabManage;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.SplitContainer splitCon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker datePickStart;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox checkDel;
        private System.Windows.Forms.RichTextBox richTxtRemark;
        private MaterialSkin.Controls.MaterialFlatButton saveSkillManageButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.RichTextBox richTxtSkillRemark;
        private MaterialSkin.Controls.MaterialCheckBox checkSkillDel;
        private System.Windows.Forms.TextBox txtSkillName;
        private System.Windows.Forms.ComboBox comboSkillType;
        private MaterialSkin.Controls.MaterialFlatButton closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxSkill;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.ComboBox comboBoxSkill;
        private System.Windows.Forms.SplitContainer splitConSkill;
        private System.Windows.Forms.ListBox listBoxSkillEdit;
        private MaterialSkin.Controls.MaterialFlatButton saveSkillButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}