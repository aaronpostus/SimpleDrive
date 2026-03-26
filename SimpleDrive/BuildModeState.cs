namespace SimpleDriveApp
{
    /// <summary>
    /// Shared state for the build mode toggle, accessible from both admin and builder views.
    /// </summary>
    public static class BuildModeState
    {
        private static bool _isBuildModeEnabled;

        public static bool IsBuildModeEnabled
        {
            get => _isBuildModeEnabled;
            set
            {
                if (_isBuildModeEnabled != value)
                {
                    _isBuildModeEnabled = value;
                    BuildModeChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Raised when build mode is toggled.
        /// </summary>
        public static event EventHandler BuildModeChanged;
    }
}
