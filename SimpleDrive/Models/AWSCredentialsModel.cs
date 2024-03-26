using Amazon;
namespace SimpleDriveApp.Models
{
    public class AWSCredentialsModel
    {
        public string AccessKey { get; private set; }
        public string SecretKey { get; private set; }
        public RegionEndpoint Region { get; private set; }

        public AWSCredentialsModel(string accessKey, string secretKey, RegionEndpoint region)
        {
            AccessKey = accessKey;
            SecretKey = secretKey;
            Region = region;
        }
    }
}