using SimpleDriveApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDriveApp.Controllers
{
    public class RegistrationController
    {
        SessionModel _session;
        public RegistrationController(SessionModel session) { 
            _session = session;
        }
        public async Task RegisterAsync(string username, string password, string email)
        {
            var userAttributes = new Dictionary<string, string> { { "email", email } };
            var signUpTask = _session.UserPool.SignUpAsync(username, password, userAttributes, userAttributes);
            await signUpTask.ConfigureAwait(false);
        }
    }
}
