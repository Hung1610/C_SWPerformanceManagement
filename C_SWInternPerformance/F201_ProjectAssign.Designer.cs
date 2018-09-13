namespace WindowsFormsApp1
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
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProjectAssign)).BeginInit();
            this.SuspendLayout();
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.BackColor = System.Drawing.Color.Transparent;
            this.projectName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.projectName.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.projectName.Location = new System.Drawing.Point(49, 49);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(134, 27);
            this.projectName.TabIndex = 0;
            this.projectName.Text = "Project Name";
            // 
            // projectNameBox
            // 
            this.projectNameBox.FormattingEnabled = true;
            this.projectNameBox.Location = new System.Drawing.Point(228, 50);
            this.projectNameBox.Name = "projectNameBox";
            this.projectNameBox.Size = new System.Drawing.Size(250, 24);
            this.projectNameBox.TabIndex = 1;
            this.projectNameBox.SelectedIndexChanged += new System.EventHandler(this.projectNameBox_SelectedIndexChanged);
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
            this.closeButton.Click += new System.EventHandler(this.close_Click);
            // 
            // dataProjectAssign
            // 
            this.dataProjectAssign.AllowUserToAddRows = false;
            this.dataProjectAssign.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataProjectAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProjectAssign.Location = new System.Drawing.Point(12, 95);
            this.dataProjectAssign.Name = "dataProjectAssign";
            this.dataProjectAssign.RowTemplate.Height = 24;
            this.dataProjectAssign.Size = new System.Drawing.Size(776, 258);
            this.dataProjectAssign.TabIndex = 4;
            this.dataProjectAssign.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProjectAssign_RowEnter);
            this.dataProjectAssign.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProjectAssign_RowLeave);
            this.dataProjectAssign.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataProjectAssign_UserDeletingRow);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(551, 44);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(206, 32);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "New Assignment";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // F201_ProjectAssign
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataProjectAssign);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.projectNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F201_ProjectAssign";
            this.Text = "F201_ProjectAssign";
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
        private System.Windows.Forms.Button addButton;
    }
}