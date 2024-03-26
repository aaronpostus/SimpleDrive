using SimpleDriveApp.Controllers;
using SimpleDriveApp.Models;
using System.Xml.Linq;
using static SimpleDrive.SimpleDriveView;

namespace SimpleDriveApp
{
    public partial class Drive : View
    {
        private ImageList _imageList;
        private FileSystemController _controller;
        private SessionModel _sessionModel;
        public Drive(FileSystemController controller, SessionModel sessionModel)
        {
            InitializeComponent();

            _imageList = new ImageList { ImageSize = new Size(32, 32) };
            _controller = controller;
            _sessionModel = sessionModel;
            ListView.LargeImageList = _imageList;
            ListView.Cursor = Cursors.Default;

            SetupBindings();
        }
        private void SetupBindings()
        {
            Logout.Click += Logout_Click;
            Rename.Click += Rename_Click;
            Upload.Click += Upload_Click;
            Share.Click += Share_Click;
            Delete.Click += Delete_Click;
            Download.Click += DownloadButton_Click;
            ListView.AfterLabelEdit += ListView_RenameAttempt;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            _controller.LogOut();
            ListView.Items.Clear();
            _imageList.Images.Clear();
        }

        private async void Upload_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    await _controller.UploadFileAsync(openFileDialog.FileName);
                    RefreshFolderView();
                    MessageBox.Show("File uploaded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to upload file: {ex.Message}");
                }
            }
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must have a file selected to rename it.");
                return;
            }
            ListView.SelectedItems[0].BeginEdit();
        }
        private void ListView_RenameAttempt(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null || e.Label.Trim() == string.Empty)
            {
                e.CancelEdit = true;
                return;
            }
            string originalFileName = ListView.Items[e.Item].Text;
            string newFileName = e.Label.Trim();
            if (newFileName != originalFileName)
            {
                try
                {
                    _controller.ListView_RenameAttempt(originalFileName, newFileName);
                }
                catch (Exception ex)
                {
                    e.CancelEdit = true;
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Share_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must have a file selected first.");
                return;
            }
            try
            {
                _controller.CopySharableLinkToClipboard(ListView.SelectedItems[0].Text);
                MessageBox.Show("URL copied to clipboard. Your Link will expire in 1 hour.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to generate pre-signed URL: {ex.Message}");
            }
        }
        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItems == null)
            {
                MessageBox.Show("You must have a file selected first.");
                return;
            }
            foreach (ListViewItem item in ListView.SelectedItems)
            {
                try
                {
                    // Using the displayed file name from the ListViewItem
                    var fileName = item.Text; 
                    var filePath = $"{AWSGlobals.FOLDER_PREFIX}{_sessionModel.CognitoUser.Username}/" + fileName;

                    var fileExtension = Path.GetExtension(fileName);
                    var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

                    var saveFileDialog = new SaveFileDialog
                    {
                        FileName = fileNameWithoutExtension,
                        DefaultExt = fileExtension
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        await _controller.Download(filePath, saveFileDialog.FileName);
                        MessageBox.Show("File downloaded successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to download file: {ex.Message}");
                }
            }
        }
        private void RefreshFolderView()
        {
            ListView.Items.Clear();
            var folderKey = $"{AWSGlobals.FOLDER_PREFIX}{_sessionModel.Username}";
            try
            {
                var fileKeys = _controller.GetFileKeysInFolder(folderKey);
                foreach (string key in fileKeys)
                {
                    DisplayFileToDrive(key.Replace($"{AWSGlobals.FOLDER_PREFIX}{_sessionModel.Username}/", ""));
                }
                ListView.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select at least one file to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected file(s)?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (ListViewItem item in ListView.SelectedItems)
                {
                    try
                    {
                        await _controller.DeleteFileAsync(item.Text);
                        ListView.Items.Remove(item);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to delete file {item.Text}: {ex.Message}");
                    }
                }
                MessageBox.Show("Selected file(s) deleted successfully.");
            }
        }
        private void DisplayFileToDrive(string fileName)
        {
            ListViewItem item = new(fileName);
            _imageList.Images.Add(Resources.Unknown);
            item.ImageIndex = _imageList.Images.Count - 1;
            ListView.Items.Add(item);
        }
        public override void SwitchToView()
        {
            viewingUserBox.Text = $"Viewing {_sessionModel.Username}'s SimpleDrive files.";
            RefreshFolderView();
        }
    }
}
