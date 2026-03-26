using SimpleDriveApp.Models;
using static SimpleDrive.SimpleDriveView;

namespace SimpleDriveApp
{
    public partial class BuilderView : View
    {
        private readonly SessionModel _sessionModel;

        public BuilderView(SessionModel sessionModel)
        {
            _sessionModel = sessionModel;
            InitializeComponent();
            SetupBindings();
            UpdateBuildModeDisplay();
        }

        private void SetupBindings()
        {
            BuildModeToggle.Click += BuildModeToggle_Click;
            TeleportToSchematics.Click += TeleportToSchematics_Click;
            BackButton.Click += BackButton_Click;
            BuildModeState.BuildModeChanged += OnBuildModeChanged;
        }

        private void BuildModeToggle_Click(object sender, EventArgs e)
        {
            BuildModeState.IsBuildModeEnabled = !BuildModeState.IsBuildModeEnabled;
        }

        private void TeleportToSchematics_Click(object sender, EventArgs e)
        {
            var schematicsPath = Registry.GetPath("schematics");
            if (schematicsPath != null)
            {
                MessageBox.Show($"Navigating to schematics location: {schematicsPath}", "Teleport to Schematics");
            }
            else
            {
                MessageBox.Show("Schematics location not found in registry.", "Error");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DisplayScreen(UserControlType.DRIVE);
        }

        private void OnBuildModeChanged(object sender, EventArgs e)
        {
            UpdateBuildModeDisplay();
        }

        private void UpdateBuildModeDisplay()
        {
            BuildModeToggle.Text = BuildModeState.IsBuildModeEnabled ? "Build Mode: ON" : "Build Mode: OFF";
            BuildModeStatus.Text = BuildModeState.IsBuildModeEnabled ? "Build Mode is currently enabled." : "Build Mode is currently disabled.";
        }

        public override void SwitchToView()
        {
            UpdateBuildModeDisplay();
        }
    }
}
