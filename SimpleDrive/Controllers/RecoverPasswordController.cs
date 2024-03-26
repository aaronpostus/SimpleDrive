using Amazon.CognitoIdentityProvider.Model;
using SimpleDriveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SimpleDriveApp.Controllers
{
    public class RecoverPasswordController
    {
        private readonly SessionModel _sessionModel;
        public RecoverPasswordController(SessionModel sessionModel)
        {
            _sessionModel = sessionModel;
        }
        public async Task SendResetCode(string username) {
            await _sessionModel.CognitoService.ForgotPasswordAsync(new ForgotPasswordRequest
            {
                ClientId = AWSGlobals.CLIENT_ID,
                Username = username
            });
            _sessionModel.Username = username;
        }
        public async Task ResetPassword(string verificationCode, string newPassword) {
            await _sessionModel.CognitoService.ConfirmForgotPasswordAsync(new ConfirmForgotPasswordRequest
            {
                ClientId = AWSGlobals.CLIENT_ID,
                Username = _sessionModel.Username,
                ConfirmationCode = verificationCode,
                Password = newPassword
            });
        }
    }
}
