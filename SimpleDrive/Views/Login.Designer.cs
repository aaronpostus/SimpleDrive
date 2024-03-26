namespace SimpleDriveApp
{
    partial class LoginView
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Button();
            this.Recover = new System.Windows.Forms.Button();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.LoginPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Controls.Add(this.panel1);
            this.LoginPanel.Controls.Add(this.passwordBox);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.usernameBox);
            this.LoginPanel.Location = new System.Drawing.Point(4, 4);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(838, 199);
            this.LoginPanel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(622, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Welcome to SimpleDrive. Login with your existing account or create an account to " +
    "get started.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.Recover);
            this.panel1.Controls.Add(this.CreateAccount);
            this.panel1.Location = new System.Drawing.Point(4, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 54);
            this.panel1.TabIndex = 8;
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(189, 30);
            this.Login.TabIndex = 6;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // Recover
            // 
            this.Recover.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.Recover.Location = new System.Drawing.Point(551, 0);
            this.Recover.Margin = new System.Windows.Forms.Padding(4);
            this.Recover.Name = "Recover";
            this.Recover.Size = new System.Drawing.Size(189, 30);
            this.Recover.TabIndex = 7;
            this.Recover.Text = "Forgot Password?";
            this.Recover.UseVisualStyleBackColor = true;
            // 
            // CreateAccount
            // 
            this.CreateAccount.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.CreateAccount.Location = new System.Drawing.Point(279, 0);
            this.CreateAccount.Margin = new System.Windows.Forms.Padding(4);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(189, 30);
            this.CreateAccount.TabIndex = 5;
            this.CreateAccount.Text = "New? Create Account";
            this.CreateAccount.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.passwordBox.Location = new System.Drawing.Point(94, 115);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(650, 21);
            this.passwordBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.usernameBox.Location = new System.Drawing.Point(94, 57);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(650, 21);
            this.usernameBox.TabIndex = 1;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoginPanel);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(751, 207);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel LoginPanel;
        private Label label3;
        private Panel panel1;
        private Button Login;
        private Button Recover;
        private Button CreateAccount;
        private TextBox passwordBox;
        private Label label1;
        private Label label2;
        private TextBox usernameBox;
    }
}
