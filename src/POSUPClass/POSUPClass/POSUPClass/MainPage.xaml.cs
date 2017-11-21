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

            entrar.Clicked +=  (sender,e)=>
            {
                OnClickEntrar(sender, e);
            };

            cadastro.Clicked += (sender, e) =>
            {
                OnClickCadastro(sender, e);
            };

            uploader.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new UploadFile());
            };

        }

        public void OnClickCadastro(object sender, System.EventArgs e)
		{
            Title = "Xamarin - Pós UP 2017";
        }

        

        public void OnClickEntrar(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new Settings());
            var btn = (Button)sender;

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
                case "Tickets":
                    this.Navigation.PushAsync(new MeusTickets());
                    break;

                default:
                    break;
            }

        }

    }
}
