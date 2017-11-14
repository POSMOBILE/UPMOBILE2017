using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace POSUPClass
{

    public partial class LoginPage : ContentPage, IGoogleAuthenticationDelegate
    {
        
        void OnFacebookLoginClick(object sender, System.EventArgs e)
        {
            DisplayAlert("Não Implementado", "Login com o Facebook não Implementado", "OK");
        }

        void OnGoogleLoginClick(object sender, System.EventArgs e)
        {
         
            var Configuration = new Configuration
            {
                ClientId = "",
                RedirectUrl = "http://localhost:8080/oauth2redirect",
                Scope = "profile"
            };
            if (Configuration.ClientId == "")
            {
                DisplayAlert("ClientId não configurado", "Configure o clientID da App Google no LoginPage.xaml.cs", "OK");
                return;
            }

            var Auth = new GoogleAuthenticator(Configuration.ClientId, Configuration.Scope, Configuration.RedirectUrl, this);
        }

        void OnEmailLoginClick(object sender, System.EventArgs e)
        {
            DisplayAlert("Não Implementado", "Login com o E-Mail não Implementado", "OK");
        }

        public void OnAuthenticationCompleted(GoogleOAuthToken token)
        {
            this.Navigation.PushAsync(new MainPage());
        }

        public void OnAuthenticationFailed(string message, Exception exception)
        {
            DisplayAlert("Cancelada", "Autenticação Falhou!", "OK");
        }

        public void OnAuthenticationCanceled()
        {
            DisplayAlert("Cancelada", "Autenticação Cancelada", "OK");
        }

        public LoginPage()
        {
            InitializeComponent();

        }



    }
}
