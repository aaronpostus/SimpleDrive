using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Extensions.CognitoAuthentication;
using Amazon.Runtime;
using SimpleDriveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimpleDrive.SimpleDriveView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SimpleDriveApp.Controllers
{
    public class AuthorizationController
    {
        private SessionModel _sessionModel;
        public AuthorizationController(SessionModel sessionModel) {
            _sessionModel = sessionModel;
        }
        /// <summary>
        /// Attempts to log a user in with a username and password.
        /// </summary>
        /// <remarks>
        /// This method throws exceptions with user-friendly error messages that should be caught and displayed in the View.
        /// </remarks>
        /// <exception cref="Exception">Thrown when the operation cannot be completed due to an invalid state.</exception>
        public async Task LoginAsync(string username, string password)
        {
            var user = _sessionModel.UserPool.GetUser(username);
            var authResponse = await InitiateAuthAsync(username, password).ConfigureAwait(false);

            if (authResponse.AuthenticationResult != null)
            {
                _sessionModel.CognitoUser = user;
                _sessionModel.Username = username;
                _sessionModel.Password = password;
            }
            else if (authResponse.ChallengeName == ChallengeNameType.NEW_PASSWORD_REQUIRED)
            {
                throw new Exception("New Password Functionality not implemented");
            }
            else
            {
                throw new Exception("Login failed.");
            }
        }

        private async Task<InitiateAuthResponse> InitiateAuthAsync(string userName, string password)
        {
            var authParameters = new Dictionary<string, string>
            {
                { "USERNAME", userName },
                { "PASSWORD", password }
            };

            var authRequest = new InitiateAuthRequest
            {
                ClientId = AWSGlobals.CLIENT_ID,
                AuthParameters = authParameters,
                AuthFlow = AuthFlowType.USER_PASSWORD_AUTH,
            };

            var response = await _sessionModel.CognitoService.InitiateAuthAsync(authRequest);
            return response;
        }
    }
}
