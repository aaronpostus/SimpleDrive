namespace SimpleDriveApp
{
    partial class RecoverPasswordView
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
            this.ReturnToLogin = new System.Windows.Forms.Button();
            this.SendVerificationCodePanel = new System.Windows.Forms.Panel();
            this.EnterUsernameForVerification = new SimpleDriveApp.PlaceHolderTextBox();
            this.SendVerification = new System.Windows.Forms.Button();
            this.ResetPasswordPanel = new System.Windows.Forms.Panel();
            this.ResetMyPassword = new System.Windows.Forms.Button();
            this.NewPassword = new SimpleDriveApp.PlaceHolderTextBox();
            this.VerificationCode = new SimpleDriveApp.PlaceHolderTextBox();
            this.LoginPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SendVerificationCodePanel.SuspendLayout();
            this.ResetPasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Controls.Add(this.panel1);
            this.LoginPanel.Controls.Add(this.SendVerificationCodePanel);
            this.LoginPanel.Controls.Add(this.ResetPasswordPanel);
            this.LoginPanel.Location = new System.Drawing.Point(4, 4);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(744, 205);
            this.LoginPanel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password Recovery";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReturnToLogin);
            this.panel1.Location = new System.Drawing.Point(4, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 54);
            this.panel1.TabIndex = 8;
            // 
            // ReturnToLogin
            // 
            this.ReturnToLogin.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToLogin.Location = new System.Drawing.Point(547, 20);
            this.ReturnToLogin.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnToLogin.Name = "ReturnToLogin";
            this.ReturnToLogin.Size = new System.Drawing.Size(189, 30);
            this.ReturnToLogin.TabIndex = 6;
            this.ReturnToLogin.Text = "Return to Login";
            this.ReturnToLogin.UseVisualStyleBackColor = true;
            // 
            // SendVerificationCodePanel
            // 
            this.SendVerificationCodePanel.Controls.Add(this.EnterUsernameForVerification);
            this.SendVerificationCodePanel.Controls.Add(this.SendVerification);
            this.SendVerificationCodePanel.Location = new System.Drawing.Point(3, 31);
            this.SendVerificationCodePanel.Name = "SendVerificationCodePanel";
            this.SendVerificationCodePanel.Size = new System.Drawing.Size(741, 100);
            this.SendVerificationCodePanel.TabIndex = 11;
            // 
            // EnterUsernameForVerification
            // 
            this.EnterUsernameForVerification.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterUsernameForVerification.ForeColor = System.Drawing.Color.Gray;
            this.EnterUsernameForVerification.Location = new System.Drawing.Point(3, 13);
            this.EnterUsernameForVerification.Name = "EnterUsernameForVerification";
            this.EnterUsernameForVerification.PlaceHolderText = "Enter your username";
            this.EnterUsernameForVerification.Size = new System.Drawing.Size(272, 20);
            this.EnterUsernameForVerification.TabIndex = 10;
            this.EnterUsernameForVerification.Text = "Enter your username";
            // 
            // SendVerification
            // 
            this.SendVerification.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendVerification.Location = new System.Drawing.Point(282, 7);
            this.SendVerification.Margin = new System.Windows.Forms.Padding(4);
            this.SendVerification.Name = "SendVerification";
            this.SendVerification.Size = new System.Drawing.Size(189, 30);
            this.SendVerification.TabIndex = 7;
            this.SendVerification.Text = "Send Verification Code";
            this.SendVerification.UseVisualStyleBackColor = true;
            // 
            // ResetPasswordPanel
            // 
            this.ResetPasswordPanel.Controls.Add(this.ResetMyPassword);
            this.ResetPasswordPanel.Controls.Add(this.NewPassword);
            this.ResetPasswordPanel.Controls.Add(this.VerificationCode);
            this.ResetPasswordPanel.Location = new System.Drawing.Point(3, 31);
            this.ResetPasswordPanel.Name = "ResetPasswordPanel";
            this.ResetPasswordPanel.Size = new System.Drawing.Size(741, 100);
            this.ResetPasswordPanel.TabIndex = 14;
            // 
            // ResetMyPassword
            // 
            this.ResetMyPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetMyPassword.Location = new System.Drawing.Point(547, 7);
            this.ResetMyPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ResetMyPassword.Name = "ResetMyPassword";
            this.ResetMyPassword.Size = new System.Drawing.Size(189, 30);
            this.ResetMyPassword.TabIndex = 13;
            this.ResetMyPassword.Text = "Reset My Password";
            this.ResetMyPassword.UseVisualStyleBackColor = true;
            // 
            // NewPassword
            // 
            this.NewPassword.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword.ForeColor = System.Drawing.Color.Gray;
            this.NewPassword.Location = new System.Drawing.Point(268, 13);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.PlaceHolderText = "Enter your new password";
            this.NewPassword.Size = new System.Drawing.Size(272, 20);
            this.NewPassword.TabIndex = 12;
            this.NewPassword.Text = "Enter your new password";
            // 
            // VerificationCode
            // 
            this.VerificationCode.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationCode.ForeColor = System.Drawing.Color.Gray;
            this.VerificationCode.Location = new System.Drawing.Point(3, 13);
            this.VerificationCode.Name = "VerificationCode";
            this.VerificationCode.PlaceHolderText = "Enter your verification code";
            this.VerificationCode.Size = new System.Drawing.Size(259, 20);
            this.VerificationCode.TabIndex = 11;
            this.VerificationCode.Text = "Enter your verification code";
            // 
            // RecoverPasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoginPanel);
            this.Name = "RecoverPasswordView";
            this.Size = new System.Drawing.Size(752, 213);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.SendVerificationCodePanel.ResumeLayout(false);
            this.SendVerificationCodePanel.PerformLayout();
            this.ResetPasswordPanel.ResumeLayout(false);
            this.ResetPasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel LoginPanel;
        private Label label3;
        private Panel panel1;
        private Button ReturnToLogin;
        private PlaceHolderTextBox EnterUsernameForVerification;
        private Panel SendVerificationCodePanel;
        private Button SendVerification;
        private Panel ResetPasswordPanel;
        private PlaceHolderTextBox NewPassword;
        private PlaceHolderTextBox VerificationCode;
        private Button ResetMyPassword;
    }
}
