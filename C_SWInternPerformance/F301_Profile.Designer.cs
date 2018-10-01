﻿namespace C_SWInternPerformance
{
    partial class F301_Profile
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkDel = new MaterialSkin.Controls.MaterialCheckBox();
            this.richTxtRemark = new System.Windows.Forms.RichTextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.saveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelTitle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitle.Controls.Add(this.closeButton);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(671, 54);
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
            this.closeButton.Location = new System.Drawing.Point(640, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Primary = false;
            this.closeButton.Size = new System.Drawing.Size(24, 36);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(14, 12);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(199, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Edit Your Profile";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.12303F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.87697F));
            this.tableLayoutPanel1.Controls.Add(this.checkDel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.richTxtRemark, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 79);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.78261F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 191);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // checkDel
            // 
            this.checkDel.AutoSize = true;
            this.checkDel.Depth = 0;
            this.checkDel.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkDel.Location = new System.Drawing.Point(210, 148);
            this.checkDel.Margin = new System.Windows.Forms.Padding(0);
            this.checkDel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkDel.Name = "checkDel";
            this.checkDel.Ripple = true;
            this.checkDel.Size = new System.Drawing.Size(89, 30);
            this.checkDel.TabIndex = 4;
            this.checkDel.Text = "DelFlag";
            this.checkDel.UseVisualStyleBackColor = true;
            // 
            // richTxtRemark
            // 
            this.richTxtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtRemark.Location = new System.Drawing.Point(212, 84);
            this.richTxtRemark.Margin = new System.Windows.Forms.Padding(2);
            this.richTxtRemark.Name = "richTxtRemark";
            this.richTxtRemark.Size = new System.Drawing.Size(420, 62);
            this.richTxtRemark.TabIndex = 2;
            this.richTxtRemark.Text = "";
            // 
            // txtPass
            // 
            this.txtPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPass.Location = new System.Drawing.Point(212, 43);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(420, 22);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(212, 2);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(420, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(4, 0);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(58, 24);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Email";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(4, 41);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 24);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(4, 82);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 24);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Remark";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(4, 148);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(63, 24);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Delete";
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Depth = 0;
            this.saveButton.Location = new System.Drawing.Point(598, 280);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Primary = false;
            this.saveButton.Size = new System.Drawing.Size(56, 36);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // F301_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 329);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F301_Profile";
            this.Text = "Profile Edit";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTxtRemark;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
        private MaterialSkin.Controls.MaterialFlatButton closeButton;
        private MaterialSkin.Controls.MaterialFlatButton saveButton;
        private MaterialSkin.Controls.MaterialCheckBox checkDel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}