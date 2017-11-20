using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace POSUPClass
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            uploader.Clicked += async delegate
            {
                await Navigation.PushAsync(new UploadFile());
            };
        }

       
    }
}
