using POSUPClass.Factory;
using POSUPClass.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POSUPClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursosSubcategoria : ContentPage
    {
        public ObservableCollection<CursoSubcategoria> Items { get; set; }

        public CursosSubcategoria(Subcategoria sub)
        {
            InitializeComponent();
            Title = sub.Nome;
            Items = new ObservableCollection<CursoSubcategoria>(CursoSubcategoriaFactory.Cursos.Where(i => i.IdSubcategoria.Equals(sub.Id)).ToList());
            BindingContext = this;
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var curso = e.Item as CursoSubcategoria;

            if (curso == null)
                return;

            await DisplayAlert("Curso Selecionado", curso.Nome, "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private void btnFiltros_Clicked(object sender, EventArgs e)
        {

        }
    }
}