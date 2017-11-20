using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using POSUPClass;
using Xamarin.Forms;


  
[assembly: Xamarin.Forms.Dependency(typeof(POSUPClass.Droid.DroidURLDialog))]
namespace POSUPClass.Droid
{

    public class DroidURLDialog : IURLDialog
    {
        private string txt = null;

        public string getText()
        {
            return txt;
        }

        public void show()
        {
            EditText et = new EditText(Forms.Context);
            AlertDialog.Builder ad = new AlertDialog.Builder(Forms.Context);
            ad.SetTitle("URL do vídeo:");
            ad.SetView(et); // <----

            ad.SetPositiveButton("OK",(s,ev)=>
            {
                IUploadWebService uploadWebService = DependencyService.Get<IUploadWebService>();

                int st = Xamarin.Forms.Application.Current.MainPage.Navigation.NavigationStack.Count - 1;
                ((UploadFile)Xamarin.Forms.Application.Current.MainPage.Navigation.NavigationStack[st]).SetURL(et.Text);

                uploadWebService.uploadFileAsync(new Uri(et.Text), "");
            });
            ad.Show();

            AlertDialog add = ad.Create();


        }
    }
}