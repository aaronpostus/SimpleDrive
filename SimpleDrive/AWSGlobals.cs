using Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDriveApp
{
    internal class AWSGlobals
    {
        public const string USER_POOL_ID = "us-east-2_Im6vAKT7S";
        public const string CLIENT_ID = "YOUR_CLIENT_ID";
        public const string BUCKET_NAME = "YOUR_BUCKET_NAME";
        public const string FOLDER_PREFIX = "user-files/";
        public const string IDENTITY_POOL_ID = "YOUR_IDENTITY_POOL";
        public static RegionEndpoint REGION = RegionEndpoint.USEast2;
    }
}
