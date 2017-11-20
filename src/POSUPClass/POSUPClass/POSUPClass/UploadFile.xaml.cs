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
        IURLDialog fileManager;
        

        public void click()
        {
            

           fileManager.show();
           string url = fileManager.getText();

            //web.Source = url;
       

        }

        public void SetURL(string url)
        {
           web.Source = url;
        }

        public UploadFile()
        {
            InitializeComponent();
            fileManager = DependencyService.Get<IURLDialog>();
            uploadWebService = DependencyService.Get<IUploadWebService>();


           
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            click();
        }
        
    }
}