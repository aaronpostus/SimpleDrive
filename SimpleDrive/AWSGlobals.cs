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
        public const string CLIENT_ID = "4imo6lr34e6a3n1p2adk47592i";
        public const string BUCKET_NAME = "simpledriveno1bucket";
        public const string FOLDER_PREFIX = "user-files/";
        public const string IDENTITY_POOL_ID = "us-east-2:afd4a8fd-5ac1-456f-a5f2-436ccee84713";
        public static RegionEndpoint REGION = RegionEndpoint.USEast2;
    }
}
