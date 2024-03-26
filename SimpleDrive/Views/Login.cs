using SimpleDriveApp.Controllers;
using SimpleDriveApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using static SimpleDrive.SimpleDriveView;

namespace SimpleDriveApp
{
    public partial class LoginView : View
    {
        private AuthorizationController _controller;
        public LoginView(AuthorizationController controller)
        {
            _controller = controller;
            InitializeComponent();
            SetupBindings();
        }
        private void SetupBindings()
        {
            CreateAccount.Click += CreateAccount_Click;
            Login.Click += LoginButton_Click;
            Recover.Click += RecoverPassword;
        }
        private async void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                await _controller.LoginAsync(usernameBox.Text, passwordBox.Text);
                DisplayScreen(UserControlType.DRIVE);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login failed: {ex.Message}");
            }
        }
        private void CreateAccount_Click(object sender, EventArgs e)
        {
            DisplayScreen(UserControlType.REGISTER);
        }
        private void RecoverPassword(object sender, EventArgs e)
        {
            DisplayScreen(UserControlType.RECOVER_PASSWORD);
        }
        public override void SwitchToView()
        {
            usernameBox.Text = string.Empty;
            passwordBox.Text = string.Empty;
        }
    }
}
