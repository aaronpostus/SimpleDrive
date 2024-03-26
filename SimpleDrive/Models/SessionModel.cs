using Amazon.CognitoIdentityProvider;
using Amazon.Extensions.CognitoAuthentication;
using Amazon.S3;

namespace SimpleDriveApp.Models
{
    public class SessionModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public AmazonCognitoIdentityProviderClient CognitoService { get; set; }
        public CognitoUserPool UserPool { get; set; }
        public AmazonS3Client S3Client { get; set; }
        public CognitoUser CognitoUser { get; set; }
    }
}
