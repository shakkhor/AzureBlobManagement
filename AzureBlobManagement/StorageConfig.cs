using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBlobManagement
{
    public class StorageConfig
    {
        public string StorageAccountName_Source { get; set; }
        public string StorageAccessKey_Source { get; set; }
        public string EcapRootContainerName_Source { get; set; }
        public string TenantRootDirectoryName_Source { get; set; }
        public string StorageAccountName_Destination { get; set; }
        public string StorageAccessKey_Destination { get; set; }
        public string EcapRootContainerName_Destination { get; set; }
        public string TenantRootDirectoryName_Destination { get; set; }
        public string UserId { get; set; }
        public string TenantDatabase { get; set; }
        public string DbConnectionString { get; set; }
    }
}
