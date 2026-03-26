namespace SimpleDriveApp
{
    /// <summary>
    /// A registry of named locations (S3 folder paths) used for navigation.
    /// </summary>
    public static class Registry
    {
        private static readonly Dictionary<string, string> _entries = new()
        {
            { "schematics", "schematics/" }
        };

        /// <summary>
        /// Gets the path for a named registry entry.
        /// </summary>
        public static string GetPath(string name)
        {
            if (_entries.TryGetValue(name.ToLowerInvariant(), out var path))
            {
                return path;
            }
            return null;
        }

        /// <summary>
        /// Sets or adds a path for a named registry entry.
        /// </summary>
        public static void SetPath(string name, string path)
        {
            _entries[name.ToLowerInvariant()] = path;
        }
    }
}
