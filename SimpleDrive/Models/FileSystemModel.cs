namespace SimpleDriveApp.Models
{
    internal class FileSystemModel
    {
        public string FilePath { get; set; }
        public List<string> FileNames { get; set; }

        public FileSystemModel(string filePath)
        {
            FilePath = filePath;
            FileNames = new List<string>();
        }
    }
}
