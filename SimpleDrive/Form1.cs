using Amazon;
using Amazon.CognitoIdentityProvider;
using Amazon.Runtime;
using SimpleDriveApp;
using SimpleDriveApp.Controllers;
using SimpleDriveApp.Models;

namespace SimpleDrive
{
    public partial class SimpleDriveView : Form
    {
        #region AWS Credentials
        private static readonly (string accessKey, string secretKey) CREDENTIALS = ("YOUR_ACCESS_KEY", "YOUR_SECRET_KEY");
        private static readonly RegionEndpoint REGION = RegionEndpoint.USEast2;
        #endregion

        #region Models
        private AWSCredentialsModel _awsCredentialsModel;
        private SessionModel _sessionModel;
        private FileSystemModel _fileSystemModel;
        #endregion

        #region Controllers
        private FileSystemController _fileSysController;
        private RegistrationController _registrationController;
        private AuthorizationController _authController;
        private RecoverPasswordController _recoverPassController;
        #endregion

        #region Views
        private Drive _driveView;
        private LoginView _loginView;
        private Register _registrationView;
        private RecoverPasswordView _forgotPassView;
        private AdminView _adminView;
        private BuilderView _builderView;
        #endregion

        public enum UserControlType { DRIVE, REGISTER, LOGIN, RECOVER_PASSWORD, ADMIN, BUILDER }

        private static Dictionary<UserControlType, SimpleDriveApp.View> _userControls;
        public SimpleDriveView()
        {
            InitializeComponent();

            // Set up MVC components
            InitializeModels();
            InitializeControllers();
            InitializeViews();

            _userControls = new Dictionary<UserControlType, SimpleDriveApp.View>() { 
                { UserControlType.DRIVE, _driveView },
                { UserControlType.REGISTER, _registrationView },
                { UserControlType.LOGIN, _loginView },
                { UserControlType.RECOVER_PASSWORD, _forgotPassView },
                { UserControlType.ADMIN, _adminView },
                { UserControlType.BUILDER, _builderView }
            };

            DisplayScreen(UserControlType.LOGIN);

            CommandBar.KeyDown += CommandBar_KeyDown;
        }

        private void CommandBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                var command = CommandBar.Text.Trim().ToLowerInvariant();
                CommandBar.Text = string.Empty;

                switch (command)
                {
                    case "/a":
                    case "/admin":
                        DisplayScreen(UserControlType.ADMIN);
                        break;
                    case "/build":
                        DisplayScreen(UserControlType.BUILDER);
                        break;
                }
            }
        }

        private void InitializeModels() {
            _awsCredentialsModel = new(CREDENTIALS.accessKey, CREDENTIALS.secretKey, REGION);
            var cognitoService = new AmazonCognitoIdentityProviderClient(new BasicAWSCredentials(_awsCredentialsModel.AccessKey, _awsCredentialsModel.SecretKey), _awsCredentialsModel.Region);
            _sessionModel = new()
            {
                CognitoService = cognitoService,
                UserPool = new (AWSGlobals.USER_POOL_ID, AWSGlobals.CLIENT_ID, cognitoService),
                S3Client = new (_awsCredentialsModel.AccessKey, _awsCredentialsModel.SecretKey, _awsCredentialsModel.Region)
            };
            _fileSystemModel = new("");
        }

        private void InitializeControllers()
        {
            _fileSysController = new(_sessionModel);
            _authController = new(_sessionModel);
            _registrationController = new(_sessionModel);
            _recoverPassController = new(_sessionModel);
        }
        private void InitializeViews()
        {
            _driveView = new(_fileSysController, _sessionModel);
            _loginView = new(_authController);
            _registrationView = new(_registrationController);
            _forgotPassView = new(_recoverPassController);
            _adminView = new();
            _builderView = new(_sessionModel);
            _driveView.Parent = this;
            _loginView.Parent = this;
            _registrationView.Parent = this;
            _forgotPassView.Parent = this;
            _adminView.Parent = this;
            _builderView.Parent = this;
        }

        public static void DisplayScreen(UserControlType userControl)
        {
            foreach (KeyValuePair<UserControlType, SimpleDriveApp.View> currUserControl in _userControls)
            {
                if (currUserControl.Key == userControl)
                {
                    currUserControl.Value.Visible = true;
                    currUserControl.Value.SwitchToView();
                    currUserControl.Value.Dock = DockStyle.Fill;
                }
                else
                {
                    currUserControl.Value.Visible = false;
                }
            }
        }
    }
}