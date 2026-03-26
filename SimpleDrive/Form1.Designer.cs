using SimpleDriveApp;

namespace SimpleDrive
{
    partial class SimpleDriveView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.CommandBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // CommandBar
            // 
            this.CommandBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CommandBar.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.CommandBar.Location = new System.Drawing.Point(0, 319);
            this.CommandBar.Name = "CommandBar";
            this.CommandBar.Size = new System.Drawing.Size(953, 21);
            this.CommandBar.TabIndex = 0;
            this.CommandBar.Text = "";
            // 
            // SimpleDriveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(953, 340);
            this.Controls.Add(this.CommandBar);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SimpleDriveView";
            this.Text = "SimpleDrive";
            this.ShowIcon = true;
            this.Icon = Resources._240_F_468335403_UWy5sVM1CFBDHPiHZJnjVqf2UXngvvPZ;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ImageList ImageList;
        private TextBox CommandBar;
    }
}
