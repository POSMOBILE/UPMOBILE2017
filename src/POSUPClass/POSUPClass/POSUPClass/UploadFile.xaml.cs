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
        string url = null;
        

        public void click()
        {
            

           fileManager.show();
       

        }

        public void SetURL(string url)
        {
           web.Source = url;
        }

        public UploadFile(string url = null)
        {
            InitializeComponent();
            fileManager = DependencyService.Get<IURLDialog>();

            this.url = url;

           
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (url==null)
            {
                click();

            }
        }
        
    }
}