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
        }

        void onClickCadastro(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new CadastroPage());
        }

        void onClickEntrar(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new Settings());
        }
    }
}
