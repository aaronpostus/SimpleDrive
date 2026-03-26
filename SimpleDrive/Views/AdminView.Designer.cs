namespace SimpleDriveApp
{
    partial class AdminView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            BuildModeState.BuildModeChanged -= OnBuildModeChanged;
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BuildModeToggle = new System.Windows.Forms.Button();
            this.BuildModeStatus = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.AdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminPanel
            // 
            this.AdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AdminPanel.Controls.Add(this.TitleLabel);
            this.AdminPanel.Controls.Add(this.BuildModeToggle);
            this.AdminPanel.Controls.Add(this.BuildModeStatus);
            this.AdminPanel.Controls.Add(this.BackButton);
            this.AdminPanel.Location = new System.Drawing.Point(3, 2);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(894, 259);
            this.AdminPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(5, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(109, 19);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Admin Menu";
            // 
            // BuildModeToggle
            // 
            this.BuildModeToggle.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.BuildModeToggle.Location = new System.Drawing.Point(5, 50);
            this.BuildModeToggle.Name = "BuildModeToggle";
            this.BuildModeToggle.Size = new System.Drawing.Size(200, 30);
            this.BuildModeToggle.TabIndex = 1;
            this.BuildModeToggle.Text = "Build Mode: OFF";
            this.BuildModeToggle.UseVisualStyleBackColor = true;
            // 
            // BuildModeStatus
            // 
            this.BuildModeStatus.AutoSize = true;
            this.BuildModeStatus.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.BuildModeStatus.Location = new System.Drawing.Point(215, 57);
            this.BuildModeStatus.Name = "BuildModeStatus";
            this.BuildModeStatus.Size = new System.Drawing.Size(185, 15);
            this.BuildModeStatus.TabIndex = 2;
            this.BuildModeStatus.Text = "Build Mode is currently disabled.";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.BackButton.Location = new System.Drawing.Point(5, 220);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(107, 30);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back to Drive";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdminPanel);
            this.Name = "AdminView";
            this.Size = new System.Drawing.Size(798, 263);
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button BuildModeToggle;
        private System.Windows.Forms.Label BuildModeStatus;
        private System.Windows.Forms.Button BackButton;
    }
}
