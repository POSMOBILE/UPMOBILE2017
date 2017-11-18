using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace POSUPClass
{
    public partial class SuportePage : ContentPage
    {
        public SuportePage()
        {
            InitializeComponent();

            ListView.ItemsSource = new List<SuporteModel>
            {
                new SuporteModel { Nome = "Conta/Perfil" },
                new SuporteModel { Nome = "Conta e Perfil - Geral" },
                new SuporteModel { Nome = "Notificações de conta do instrutor" },
                new SuporteModel { Nome = "Mesclar contas" },
                new SuporteModel { Nome = "Organize seus cursos da Udemy usando acervos" },
                new SuporteModel { Nome = "Minha conta foi comprometida?" },
                new SuporteModel { Nome = "Como proteger sua conta" },
                new SuporteModel { Nome = "VER TODOS OS 17 artigos" },
                new SuporteModel { Nome = "Como fazer um curso" },
                new SuporteModel { Nome = "Reprodutor do curso" },
            };
        }

        void OnEdit(object sender, EventArgs e)
        {
            
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage());
        }

        private async void ToolbarItem_Activated(object sender, EventArgs e)
        {
            DisplayAlert("Pesquisar", "Menu Ativado", "OK");
        }

    }
}
