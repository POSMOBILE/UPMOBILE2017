using POSUPClass.Model;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using POSUPClass.Factory;

namespace POSUPClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Subcategorias : ContentPage
    {
        public ObservableCollection<Subcategoria> Items { get; set; }

        public Subcategorias()
        {
            InitializeComponent();
            Title = "Negócio";
            Items = new ObservableCollection<Subcategoria>(SubcategoriaFactory.Subcategorias);
            BindingContext = this;
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var sub = e.Item as Subcategoria;
            if (sub == null)
                return;

            await this.Navigation.PushAsync(new CursosSubcategoria(sub));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}