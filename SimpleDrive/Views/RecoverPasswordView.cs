using SimpleDriveApp.Controllers;
using System.Diagnostics;
using static SimpleDrive.SimpleDriveView;

namespace SimpleDriveApp
{
    public partial class RecoverPasswordView : SimpleDriveApp.View
    {
        public static Panel VerifyPanel, ResetPanel;
        private RecoverPasswordController _controller;
        public RecoverPasswordView(RecoverPasswordController controller)
        {
            InitializeComponent();
            _controller = controller;
            SetupBindings();
            VerifyPanel = SendVerificationCodePanel;
            ResetPanel = ResetPasswordPanel;
        }
        public static void DisplayPanel(Panel panel) {
            panel.Visible = true;
            if (panel == VerifyPanel)
            {
                ResetPanel.Visible = false;
            }
            else 
            {
                VerifyPanel.Visible = false;
            }
        }
        private void SetupBindings() {
            ReturnToLogin.Click += GoBackToLogin;
            SendVerification.Click += SendCode;
            ResetMyPassword.Click += ResetPassword;
        }
        public void GoBackToLogin(object sender, EventArgs e) {
            DisplayScreen(UserControlType.LOGIN);
        }
        public async void SendCode(object sender, EventArgs e) {
            try
            {
                await _controller.SendResetCode(EnterUsernameForVerification.Text);
                DisplayPanel(ResetPanel);
                MessageBox.Show("Your reset code has been sent to your email on file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send reset code: {ex.Message}");
            }
        }
        public async void ResetPassword(object sender, EventArgs e)
        {
            try
            {
                await _controller.ResetPassword(VerificationCode.Text,NewPassword.Text);
                DisplayScreen(UserControlType.LOGIN);
                MessageBox.Show("Your password has been reset. You may now log in with your new credentials.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to reset password: {ex.Message}");
            }
        }
        public override void SwitchToView() {
            DisplayPanel(VerifyPanel);
        }
    }
}
