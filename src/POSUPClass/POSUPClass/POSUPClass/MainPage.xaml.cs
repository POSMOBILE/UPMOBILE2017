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
            Title = "Xamarin - Pós UP 2017";
        }

        void onClick(object sender, System.EventArgs e)
        {
            var btn = sender as Button;

            switch (btn.CommandParameter.ToString())
            {
                case "Cadastro":
                    this.Navigation.PushAsync(new CadastroPage());
                    break;
                case "Settings":
                    this.Navigation.PushAsync(new Settings());
                    break;
                case "Wishlist":
                    this.Navigation.PushAsync(new ListaDeDesejos());
                    break;
                case "MeusCursos":
                    this.Navigation.PushAsync(new MeusCursos());
                    break;
                case "PerfilProfessor":
                    this.Navigation.PushAsync(new PerfilProfessor());
                    break;
                case "Opinioes":
                    this.Navigation.PushAsync(new projeto_teste_lenon.TelaOpinioes());
                    break;
                case "Subcategorias":
                    this.Navigation.PushAsync(new TelaSubPag2());
                    break;
                case "SubcategoriasFiltro":
                    this.Navigation.PushAsync(new Subcategorias());
                    break;
                case "ListaCursos":
                    this.Navigation.PushAsync(new ListaCursos());
                    break;
                case "Tickets":
                    this.Navigation.PushAsync(new MeusTickets());
                    break;

                case "Video":
                    this.Navigation.PushAsync(new UploadFile());
                    break;

                default:
                    break;
            }
        }
    }
}
