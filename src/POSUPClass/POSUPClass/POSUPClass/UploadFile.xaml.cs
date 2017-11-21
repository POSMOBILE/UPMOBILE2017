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
    public partial class UploadFile : ContentPage
    {
        string url = null;
        

        public void showManager()
        {

            
                var fileManager = DependencyService.Get<IURLDialog>();

                fileManager.show();
            
       

        }

        public void SetURL(string url)
        {
           web.Source = url;
            this.url = url;
        }

        public UploadFile(string url=null)
        {
            InitializeComponent();

            click.Clicked += (sender, e) =>
             {
                 showManager();
             };

            if (url == null)
            {
                var files = DependencyService.Get<IUploadWebService>();
                var list = files.listFiles();

                if (list.Length > 0)
                {
                    SetURL( list[0].ToString());
                } 
            } else
            {
                this.url = url;
            }


        }

        



    }
}