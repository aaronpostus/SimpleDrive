using static SimpleDrive.SimpleDriveView;

namespace SimpleDriveApp
{
    public partial class AdminView : View
    {
        public AdminView()
        {
            InitializeComponent();
            SetupBindings();
            UpdateBuildModeDisplay();
        }

        private void SetupBindings()
        {
            BuildModeToggle.Click += BuildModeToggle_Click;
            BackButton.Click += BackButton_Click;
            BuildModeState.BuildModeChanged += OnBuildModeChanged;
        }

        private void BuildModeToggle_Click(object sender, EventArgs e)
        {
            BuildModeState.IsBuildModeEnabled = !BuildModeState.IsBuildModeEnabled;
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
