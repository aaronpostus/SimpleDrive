namespace SimpleDriveApp
{
    partial class Drive
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrivePanel = new System.Windows.Forms.Panel();
            this.Rename = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.Share = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            this.viewingUserBox = new System.Windows.Forms.Label();
            this.DrivePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrivePanel
            // 
            this.DrivePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DrivePanel.Controls.Add(this.Rename);
            this.DrivePanel.Controls.Add(this.ListView);
            this.DrivePanel.Controls.Add(this.Share);
            this.DrivePanel.Controls.Add(this.Delete);
            this.DrivePanel.Controls.Add(this.Logout);
            this.DrivePanel.Controls.Add(this.Upload);
            this.DrivePanel.Controls.Add(this.Download);
            this.DrivePanel.Controls.Add(this.viewingUserBox);
            this.DrivePanel.Location = new System.Drawing.Point(3, 2);
            this.DrivePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrivePanel.Name = "DrivePanel";
            this.DrivePanel.Size = new System.Drawing.Size(894, 259);
            this.DrivePanel.TabIndex = 8;
            // 
            // Rename
            // 
            this.Rename.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.Rename.Location = new System.Drawing.Point(686, 190);
            this.Rename.Margin = new System.Windows.Forms.Padding(4);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(107, 30);
            this.Rename.TabIndex = 13;
            this.Rename.Text = "Rename";
            this.Rename.UseVisualStyleBackColor = true;
            // 
            // ListView
            // 
            this.ListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListView.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ListView.HideSelection = false;
            this.ListView.LabelEdit = true;
            this.ListView.Location = new System.Drawing.Point(0, 37);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(679, 219);
            this.ListView.TabIndex = 8;
            this.ListView.UseCompatibleStateImageBehavior = false;
            // 
            // Share
            // 
            this.Share.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.Share.Location = new System.Drawing.Point(686, 114);
            this.Share.Margin = new System.Windows.Forms.Padding(4);
            this.Share.Name = "Share";
            this.Share.Size = new System.Drawing.Size(107, 30);
            this.Share.TabIndex = 12;
            this.Share.Text = "Share";
            this.Share.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.Delete.Location = new System.Drawing.Point(686, 152);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(107, 30);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.Logout.Location = new System.Drawing.Point(686, 228);
            this.Logout.Margin = new System.Windows.Forms.Padding(4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(107, 30);
            this.Logout.TabIndex = 9;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // Upload
            // 
            this.Upload.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.Upload.Location = new System.Drawing.Point(686, 40);
            this.Upload.Margin = new System.Windows.Forms.Padding(4);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(107, 30);
            this.Upload.TabIndex = 7;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            // 
            // Download
            // 
            this.Download.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.Download.Location = new System.Drawing.Point(686, 78);
            this.Download.Margin = new System.Windows.Forms.Padding(4);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(107, 30);
            this.Download.TabIndex = 8;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            // 
            // viewingUserBox
            // 
            this.viewingUserBox.AutoSize = true;
            this.viewingUserBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewingUserBox.Location = new System.Drawing.Point(5, 10);
            this.viewingUserBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewingUserBox.Name = "viewingUserBox";
            this.viewingUserBox.Size = new System.Drawing.Size(276, 19);
            this.viewingUserBox.TabIndex = 8;
            this.viewingUserBox.Text = "Viewing {username}\'s SimpleDrive files.";
            // 
            // Drive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DrivePanel);
            this.Name = "Drive";
            this.Size = new System.Drawing.Size(798, 263);
            this.DrivePanel.ResumeLayout(false);
            this.DrivePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel DrivePanel;
        private Button Rename;
        private ListView ListView;
        private Button Share;
        private Button Delete;
        private Button Logout;
        private Button Upload;
        private Button Download;
        private Label viewingUserBox;
    }
}
