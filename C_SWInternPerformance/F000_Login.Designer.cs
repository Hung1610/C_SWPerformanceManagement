﻿namespace C_SWInternPerformance
{
    partial class F000_Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.flatTxtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.flatTxtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.checkRemember = new MaterialSkin.Controls.MaterialCheckBox();
            this.labelUserWrong = new System.Windows.Forms.Label();
            this.labelPassWrong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::C_SWInternPerformance.Properties.Resources.softworld_logo_footer;
            this.pictureBox1.Location = new System.Drawing.Point(38, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Depth = 0;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(147, 411);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Primary = false;
            this.closeButton.Size = new System.Drawing.Size(54, 36);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "CLOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // flatTxtUser
            // 
            this.flatTxtUser.BackColor = System.Drawing.Color.LightGray;
            this.flatTxtUser.Depth = 0;
            this.flatTxtUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flatTxtUser.Hint = "";
            this.flatTxtUser.Location = new System.Drawing.Point(38, 225);
            this.flatTxtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatTxtUser.Name = "flatTxtUser";
            this.flatTxtUser.PasswordChar = '\0';
            this.flatTxtUser.SelectedText = "";
            this.flatTxtUser.SelectionLength = 0;
            this.flatTxtUser.SelectionStart = 0;
            this.flatTxtUser.Size = new System.Drawing.Size(271, 23);
            this.flatTxtUser.TabIndex = 1;
            this.flatTxtUser.Text = "Enter Email";
            this.flatTxtUser.UseSystemPasswordChar = false;
            this.flatTxtUser.Enter += new System.EventHandler(this.userTxt_Enter);
            this.flatTxtUser.Leave += new System.EventHandler(this.userTxt_Leave);
            // 
            // flatTxtPass
            // 
            this.flatTxtPass.BackColor = System.Drawing.Color.LightGray;
            this.flatTxtPass.Depth = 0;
            this.flatTxtPass.Hint = "";
            this.flatTxtPass.Location = new System.Drawing.Point(38, 271);
            this.flatTxtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatTxtPass.Name = "flatTxtPass";
            this.flatTxtPass.PasswordChar = '\0';
            this.flatTxtPass.SelectedText = "";
            this.flatTxtPass.SelectionLength = 0;
            this.flatTxtPass.SelectionStart = 0;
            this.flatTxtPass.Size = new System.Drawing.Size(271, 23);
            this.flatTxtPass.TabIndex = 2;
            this.flatTxtPass.Text = "Password";
            this.flatTxtPass.UseSystemPasswordChar = false;
            this.flatTxtPass.Enter += new System.EventHandler(this.passTxt_Enter);
            this.flatTxtPass.Leave += new System.EventHandler(this.passTxt_Leave);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Depth = 0;
            this.loginButton.Location = new System.Drawing.Point(38, 365);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = true;
            this.loginButton.Size = new System.Drawing.Size(271, 37);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // checkRemember
            // 
            this.checkRemember.AutoSize = true;
            this.checkRemember.Depth = 0;
            this.checkRemember.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkRemember.Location = new System.Drawing.Point(38, 318);
            this.checkRemember.Margin = new System.Windows.Forms.Padding(0);
            this.checkRemember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkRemember.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkRemember.Name = "checkRemember";
            this.checkRemember.Ripple = true;
            this.checkRemember.Size = new System.Drawing.Size(120, 30);
            this.checkRemember.TabIndex = 6;
            this.checkRemember.Text = "Remember Me";
            this.checkRemember.UseVisualStyleBackColor = true;
            // 
            // labelUserWrong
            // 
            this.labelUserWrong.AutoSize = true;
            this.labelUserWrong.ForeColor = System.Drawing.Color.Red;
            this.labelUserWrong.Location = new System.Drawing.Point(38, 252);
            this.labelUserWrong.Name = "labelUserWrong";
            this.labelUserWrong.Size = new System.Drawing.Size(91, 13);
            this.labelUserWrong.TabIndex = 7;
            this.labelUserWrong.Text = "Unavailable Email";
            this.labelUserWrong.Visible = false;
            // 
            // labelPassWrong
            // 
            this.labelPassWrong.AutoSize = true;
            this.labelPassWrong.ForeColor = System.Drawing.Color.Red;
            this.labelPassWrong.Location = new System.Drawing.Point(38, 302);
            this.labelPassWrong.Name = "labelPassWrong";
            this.labelPassWrong.Size = new System.Drawing.Size(112, 13);
            this.labelPassWrong.TabIndex = 8;
            this.labelPassWrong.Text = "Unavailable Password";
            this.labelPassWrong.Visible = false;
            // 
            // F000_Login
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 462);
            this.ControlBox = false;
            this.Controls.Add(this.labelPassWrong);
            this.Controls.Add(this.labelUserWrong);
            this.Controls.Add(this.checkRemember);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.flatTxtPass);
            this.Controls.Add(this.flatTxtUser);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F000_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.F000_Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton closeButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField flatTxtUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField flatTxtPass;
        private MaterialSkin.Controls.MaterialRaisedButton loginButton;
        private MaterialSkin.Controls.MaterialCheckBox checkRemember;
        private System.Windows.Forms.Label labelUserWrong;
        private System.Windows.Forms.Label labelPassWrong;
    }
}