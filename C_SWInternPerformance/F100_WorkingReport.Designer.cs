namespace C_SWInternPerformance
{
    partial class F100_WorkingReport
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
            this.projectBox = new System.Windows.Forms.ComboBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.workTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.remarkRichTxt = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.closeButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.submitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.workTimeUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectBox
            // 
            this.projectBox.FormattingEnabled = true;
            this.projectBox.Location = new System.Drawing.Point(205, 2);
            this.projectBox.Margin = new System.Windows.Forms.Padding(2);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(250, 21);
            this.projectBox.TabIndex = 1;
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(205, 57);
            this.datePick.Margin = new System.Windows.Forms.Padding(2);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(250, 20);
            this.datePick.TabIndex = 2;
            // 
            // workTimeUpDown
            // 
            this.workTimeUpDown.Location = new System.Drawing.Point(205, 112);
            this.workTimeUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.workTimeUpDown.Name = "workTimeUpDown";
            this.workTimeUpDown.Size = new System.Drawing.Size(96, 20);
            this.workTimeUpDown.TabIndex = 3;
            // 
            // remarkRichTxt
            // 
            this.remarkRichTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remarkRichTxt.Location = new System.Drawing.Point(205, 167);
            this.remarkRichTxt.Margin = new System.Windows.Forms.Padding(2);
            this.remarkRichTxt.Name = "remarkRichTxt";
            this.remarkRichTxt.Size = new System.Drawing.Size(282, 87);
            this.remarkRichTxt.TabIndex = 4;
            this.remarkRichTxt.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.datePick, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.remarkRichTxt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.projectBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.workTimeUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 66);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.78261F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 256);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 43);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(10, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(150, 25);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Working Report";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Depth = 0;
            this.closeButton.Location = new System.Drawing.Point(483, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Primary = false;
            this.closeButton.Size = new System.Drawing.Size(21, 36);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButton.Depth = 0;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submitButton.Location = new System.Drawing.Point(433, 330);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton.Name = "submitButton";
            this.submitButton.Primary = false;
            this.submitButton.Size = new System.Drawing.Size(62, 36);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Project";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 55);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Date";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 110);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(102, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Working Time";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 165);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(60, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Remark";
            // 
            // F100_WorkingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F100_WorkingReport";
            this.Text = "F100_WorkingReport";
            ((System.ComponentModel.ISupportInitialize)(this.workTimeUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox projectBox;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.NumericUpDown workTimeUpDown;
        private System.Windows.Forms.RichTextBox remarkRichTxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton submitButton;
        private MaterialSkin.Controls.MaterialFlatButton closeButton;
        private System.Windows.Forms.Label labelTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}