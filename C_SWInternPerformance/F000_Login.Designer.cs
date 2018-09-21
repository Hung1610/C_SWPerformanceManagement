namespace C_SWInternPerformance
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
            this.loginButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.closeButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.flatTxtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.flatTxtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::C_SWInternPerformance.Properties.Resources.softworld_logo_footer;
            this.pictureBox1.Location = new System.Drawing.Point(38, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginButton.Depth = 0;
            this.loginButton.Location = new System.Drawing.Point(38, 379);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = false;
            this.loginButton.Size = new System.Drawing.Size(60, 36);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Sign In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Depth = 0;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(255, 379);
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
            this.flatTxtUser.Location = new System.Drawing.Point(38, 294);
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
            this.flatTxtPass.Location = new System.Drawing.Point(38, 332);
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
            // F000_Login
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 436);
            this.ControlBox = false;
            this.Controls.Add(this.flatTxtPass);
            this.Controls.Add(this.flatTxtUser);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F000_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton loginButton;
        private MaterialSkin.Controls.MaterialFlatButton closeButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField flatTxtUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField flatTxtPass;
    }
}