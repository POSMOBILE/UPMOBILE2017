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
            this.Navigation.PushAsync(new CadastroPage());
        }

        public void OnClickEntrar(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new Settings());
        }

    }
}
