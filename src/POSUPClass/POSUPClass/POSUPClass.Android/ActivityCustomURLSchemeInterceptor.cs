using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Content;

namespace POSUPClass.Droid
{
    [Activity(Label = "ActivityCustomUrlSchemeInterceptor", NoHistory = true, LaunchMode = LaunchMode.SingleTop)]
    [
    IntentFilter
    (
        actions: new[] { Intent.ActionView },
        Categories = new[]
                {
                    Intent.CategoryDefault,
                    Intent.CategoryBrowsable
                },
            DataSchemes = new[]
                    {
                        "com.xamarin.traditional.standard.samples.oauth.providers.android",
                        "com.googleusercontent.apps.743999266064-7vron5gi5r0v0bhj2jgvu29ihjckdp8a",
                   
                        "xamarin-auth",
                        "urn:ietf:wg:oauth:2.0:oob",
                        "urn:ietf:wg:oauth:2.0:oob.auto",
                        "http://localhost:8080",
                        "https://localhost:8080",
                        "http://127.0.0.1:8080",
                        "https://127.0.0.1:8080",              
                        "http://[::1]:8080", 
                        "https://[::1]:8080"
                       
                    },
            DataHosts = new[] {
            "localhost",
            "authorize"
             },
          DataPaths =  new[] {
                    "/oauth2redirect",
                 "/",
             },
            AutoVerify = true
    )   
]
    public class ActivityCustomURLSchemeInterceptor : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            global::Android.Net.Uri uri_android = Intent.Data;

            // Convert Android.Net.Url to C#/netxf/BCL System.Uri - common API
            Uri uri_netfx = new Uri(uri_android.ToString());

            // load redirect_url Page for parsing
            AuthenticationState.Authenticator.OnPageLoading(uri_netfx);

            this.Finish();

            return;
        }
    }
}
