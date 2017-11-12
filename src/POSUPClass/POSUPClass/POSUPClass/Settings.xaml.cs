using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POSUPClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            SettingsBinding settings = new SettingsBinding();
            settings.ContinueLectureBackground = true;
            settings.DownloadToSdCard = false;
            settings.DownloadWiFiOnly = true;
            settings.VideoQuality = 1;
            BindingContext = settings;
            InitializeComponent();
        }
    }
}