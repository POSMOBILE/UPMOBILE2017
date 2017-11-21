using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass
{
    class SettingsBinding
    {
        public bool ContinueLectureBackground { get; set; }
        public bool DownloadWiFiOnly { get; set; }
        public bool DownloadToSdCard { get; set; }
        public int VideoQuality { get; set; }
    }
}
