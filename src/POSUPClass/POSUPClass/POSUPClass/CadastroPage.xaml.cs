using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace POSUPClass
{
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();

            cadastrar.Clicked += (sender, e) => {
                onCadastrarClicked(sender, e);
            };

            voltar.Clicked += (sender, e) =>
            {
                onBackClicked(sender, e);
            };
        }

        public void onCadastrarClicked(object sender, EventArgs args)
        {
            var nameValue = nome.Text;
            if (String.IsNullOrEmpty(nameValue))
            {
                DisplayAlert("Erro", "O campo nome não pode ser nulo", "OK");
                return;
            }

            var emailValue = email.Text;
            if (String.IsNullOrEmpty(emailValue))
            {
                DisplayAlert("Erro", "O campo email não pode ser nulo", "OK");
                return;
            }

            var senhaValue = senha.Text;
            if (String.IsNullOrEmpty(senhaValue))
            {
                DisplayAlert("Erro", "O campo senha não pode ser nulo", "OK");
                return;
            }

            DisplayAlert("", "Cadastro realizado com sucesso", "OK");
            this.Navigation.PopAsync();
        }

        public void onBackClicked(object sender, EventArgs args)
        {
            this.Navigation.PopAsync();
        }
    }
}
