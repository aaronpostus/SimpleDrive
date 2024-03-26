using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimpleDrive.SimpleDriveView;
using System.Windows.Forms;
using SimpleDriveApp.Models;
using Amazon.Extensions.CognitoAuthentication;
using Amazon.S3.Model;
using SimpleDrive;

namespace SimpleDriveApp.Controllers
{
    public class FileSystemController
    {
        private readonly SessionModel _sessionModel;
        public FileSystemController(SessionModel sessionModel)
        {
            _sessionModel = sessionModel;
        }
        public void LogOut()
        {
            _sessionModel.CognitoUser?.SignOut();
            _sessionModel.CognitoUser = null;
            DisplayScreen(UserControlType.LOGIN);
        }
        public async Task DeleteFileAsync(string fileName)
        {
            string filePath = $"{AWSGlobals.FOLDER_PREFIX}{_sessionModel.CognitoUser.Username}/{fileName}";
            var deleteRequest = new DeleteObjectRequest
            {
                BucketName = AWSGlobals.BUCKET_NAME,
                Key = filePath
            };
            await _sessionModel.S3Client.DeleteObjectAsync(deleteRequest);
        }

        public async Task UploadFileAsync(string filePath)
        {
            var fileName = Path.GetFileName(filePath);
            var fileStream = File.OpenRead(filePath);
            var key = $"{AWSGlobals.FOLDER_PREFIX}{_sessionModel.CognitoUser.Username}/{fileName}";

            var putRequest = new PutObjectRequest
            {
                BucketName = AWSGlobals.BUCKET_NAME,
                Key = key,
                InputStream = fileStream
            };
            await _sessionModel.S3Client.PutObjectAsync(putRequest).ConfigureAwait(false);
        }

        public List<string> GetFileKeysInFolder(string folderKey)
        {
            var fileKeys = new List<string>();

            var request = new ListObjectsV2Request
            {
                BucketName = AWSGlobals.BUCKET_NAME,
                Prefix = folderKey
            };

            ListObjectsV2Response response;
            do
            {
                response = _sessionModel.S3Client.ListObjectsV2Async(request).GetAwaiter().GetResult();

                foreach (var obj in response.S3Objects)
                {
                    fileKeys.Add(obj.Key);
                }

                request.ContinuationToken = response.NextContinuationToken;
            } while (response.IsTruncated);

            return fileKeys;
        }

        public void CopySharableLinkToClipboard(string fileName)
        {
            string presignedURL = GeneratePreSignedURL($"{AWSGlobals.FOLDER_PREFIX}{_sessionModel.CognitoUser.Username}/" + fileName);
            if (presignedURL != null)
            {
                Clipboard.SetText(presignedURL);
            }
            else
            {
                throw new Exception("Presigned URL is null.");
            }
        }
        private string GeneratePreSignedURL(string filePath)
        {
            // Generate a pre-signed URL with a temporary expiration time
            var request = new GetPreSignedUrlRequest
            {
                BucketName = AWSGlobals.BUCKET_NAME,

                Key = filePath,
                Expires = DateTime.Now.AddHours(1)
            };

            return _sessionModel.S3Client.GetPreSignedURL(request);
        }

        public void ListView_RenameAttempt(string originalFileName, string newFileName)
        {
            string oldFilePath = $"{AWSGlobals.FOLDER_PREFIX}{_sessionModel.CognitoUser.Username}/{originalFileName}";
            string newFilePath = $"{AWSGlobals.FOLDER_PREFIX}{_sessionModel.CognitoUser.Username}/{newFileName}";
            // Check if the new file name already exists in the S3 bucket
            GetObjectMetadataRequest metadataRequest = new GetObjectMetadataRequest
            {
                BucketName = AWSGlobals.BUCKET_NAME,
                Key = newFilePath
            };
            try
            {
                // If the object exists, it means the new file name is already taken
                GetObjectMetadataResponse response = _sessionModel.S3Client.GetObjectMetadata(metadataRequest);
                throw new Exception("A file with the same name already exists. Please choose a different name.");
            }
            // Throws exception if the file doesn't exist
            catch (Exception)
            {
                try
                {
                    RenameFileInS3(oldFilePath, newFilePath);
                }
                catch
                {
                    throw new Exception("Failed to rename the file in the S3 bucket.");
                }
            }
        }

        private void RenameFileInS3(string oldFilePath, string newFilePath)
        {
            try
            {
                // Copy the object with the new key (file name)
                CopyObjectRequest copyRequest = new CopyObjectRequest
                {
                    SourceBucket = AWSGlobals.BUCKET_NAME,
                    SourceKey = oldFilePath,
                    DestinationBucket = AWSGlobals.BUCKET_NAME,
                    DestinationKey = newFilePath
                };
                _sessionModel.S3Client.CopyObject(copyRequest);

                // Delete the original object
                DeleteObjectRequest deleteRequest = new DeleteObjectRequest
                {
                    BucketName = AWSGlobals.BUCKET_NAME,
                    Key = oldFilePath
                };
                _sessionModel.S3Client.DeleteObject(deleteRequest);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to rename file in S3: {ex.Message}");
            }
        }
        public async Task Download(string filePath, string savePath)
        {
            using var response = await _sessionModel.S3Client.GetObjectAsync(AWSGlobals.BUCKET_NAME, filePath);
            using var responseStream = response.ResponseStream;
            using var fileStream = File.Create(savePath); 
            await responseStream.CopyToAsync(fileStream);
        }
    }
}
