﻿namespace C_SWInternPerformance
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
            this.label4 = new System.Windows.Forms.Label();
            this.projectBox = new System.Windows.Forms.ComboBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.workTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.remarkRichTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workTimeUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Remarks";
            // 
            // projectBox
            // 
            this.projectBox.FormattingEnabled = true;
            this.projectBox.Location = new System.Drawing.Point(228, 3);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(311, 24);
            this.projectBox.TabIndex = 1;
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(228, 66);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(311, 22);
            this.datePick.TabIndex = 2;
            // 
            // workTimeUpDown
            // 
            this.workTimeUpDown.Location = new System.Drawing.Point(228, 129);
            this.workTimeUpDown.Name = "workTimeUpDown";
            this.workTimeUpDown.Size = new System.Drawing.Size(120, 22);
            this.workTimeUpDown.TabIndex = 3;
            // 
            // remarkRichTxt
            // 
            this.remarkRichTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remarkRichTxt.Location = new System.Drawing.Point(228, 192);
            this.remarkRichTxt.Name = "remarkRichTxt";
            this.remarkRichTxt.Size = new System.Drawing.Size(311, 97);
            this.remarkRichTxt.TabIndex = 4;
            this.remarkRichTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Working Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Project";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Gold;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(13, 414);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(182, 61);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Gold;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(373, 414);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(182, 61);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.datePick, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.remarkRichTxt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.projectBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.workTimeUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.78261F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 292);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 68);
            this.panel1.TabIndex = 7;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(21, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(234, 39);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Working Report";
            // 
            // F100_WorkingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(567, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.submitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F100_WorkingReport";
            this.Text = "F100_WorkingReport";
            ((System.ComponentModel.ISupportInitialize)(this.workTimeUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox projectBox;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.NumericUpDown workTimeUpDown;
        private System.Windows.Forms.RichTextBox remarkRichTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
    }
}