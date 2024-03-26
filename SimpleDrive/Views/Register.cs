using SimpleDriveApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimpleDrive.SimpleDriveView;

namespace SimpleDriveApp
{
    public partial class Register : View
    {
        private RegistrationController _controller;
        public Register(RegistrationController controller)
        {
            InitializeComponent();
            SetupBindings();
            _controller = controller;
        }
        private void SetupBindings() { 
            RegisterButton.Click += RegisterButton_Click;
            ReturnHome.Click += ReturnToHome_Click;
        }
        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                await _controller.RegisterAsync(userBox.Text, passBox.Text, emailBox.Text);
                DisplayScreen(UserControlType.LOGIN);
                MessageBox.Show("Registration successful! Please check your email to verify your account.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed: {ex.Message}");
            }
        }
        private void ReturnToHome_Click(object sender, EventArgs e)
        {
            DisplayScreen(UserControlType.LOGIN);
        }
        public override void SwitchToView()
        {
            userBox.Text = string.Empty;
            passBox.Text = string.Empty;
            emailBox.Text = string.Empty;
        }
    }
}
