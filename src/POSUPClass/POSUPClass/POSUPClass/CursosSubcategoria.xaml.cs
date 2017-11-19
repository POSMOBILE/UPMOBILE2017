using POSUPClass.Custom;
using POSUPClass.Factory;
using POSUPClass.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POSUPClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursosSubcategoria : ContentPage
    {
        public ObservableCollection<CursoSubcategoria> Items { get; set; }

        public Dictionary<String, Int32> ItemsOrdenarPor = new Dictionary<string, int>
        {
            { "Avaliações", 0 },
            { "Mais recente", 1 },
            { "Preço Menor para Maior", 2 },
            { "Preço Maior para Menor", 3 }
        };

        public List<String> ItemsTiposPrecos = new List<String> { "Pago", "Gratuito" };

        public CursosSubcategoria(Subcategoria sub)
        {
            InitializeComponent();
            Title = sub.Nome;
            Items = new ObservableCollection<CursoSubcategoria>(CursoSubcategoriaFactory.Cursos.Where(i => i.IdSubcategoria.Equals(sub.Id)).ToList());
            BindingContext = this;

            foreach (var item in ItemsOrdenarPor)
            {
                picOrdenarPor.Items.Add(item.Key);
            }

            layoutModalControls.Children.Add(new RadioButtonControl("Teste"));
            layoutModalControls.Children.Add(new RadioButtonControl("Teste", true));

            //rbgPrecos.ItemsSource = ItemsTiposPrecos;
            //var radios = this.layoutModalControls.Children.OfType<Radio>().ToList();
            //foreach (var r in radios)
            //{
            //    r.OnImg = ImageSource.FromResource("POSUPClass.Resources.Images.radio_on.png");
            //    r.OffImg = ImageSource.FromResource("POSUPClass.Resources.Images.radio_off.png");
            //}
        }

        protected override bool OnBackButtonPressed()
        {
            if (layoutModal.IsVisible)
            {
                layoutModal.IsVisible = false;
                NavigationPage.SetHasNavigationBar(this, true);
                return true;
            }

            return base.OnBackButtonPressed();
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

        private async void btnFiltros_Clicked(object sender, EventArgs e)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            layoutModal.IsVisible = true;
        }
    }
}