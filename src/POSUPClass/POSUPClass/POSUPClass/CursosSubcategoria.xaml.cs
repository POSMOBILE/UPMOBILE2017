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
        public List<CursoSubcategoria> ListaOriginal { get; set; }
        public List<CursoSubcategoria> ListaAuxiliar { get; set; }
        public ObservableCollection<CursoSubcategoria> Items { get; set; }

        private ListBox ListBoxOrdenar = new ListBox(new List<string> { "Preço Menor para Maior", "Preço Maior para Menor" });

        public CursosSubcategoria(Subcategoria sub)
        {
            InitializeComponent();

            this.layoutModalControls.Children.Add(ListBoxOrdenar);
            Title = sub.Nome;
            ListaOriginal = CursoSubcategoriaFactory.Cursos.Where(i => i.IdSubcategoria.Equals(sub.Id)).OrderBy(i => i.PrecoAtual).ToList();
            Items = new ObservableCollection<CursoSubcategoria>(ListaOriginal);
            ListaAuxiliar = new List<CursoSubcategoria>();
            ListaAuxiliar.AddRange(ListaOriginal);
            BindingContext = this;

            this.lblHeaderModal.Text = $"Cursos {Items.Count}";


            InserirRadioButtons();
        }

        private void InserirRadioButtons()
        {
            //Preço
            layoutModalControls.Children.Add(new Label { TextColor = Color.Black, Text = "Preço", FontAttributes = FontAttributes.Bold });

            var cursosPagos = Items.Count(i => i.Pago);
            if (cursosPagos > 0)
                layoutModalControls.Children.Add(new RadioButtonControl($"Pago ({cursosPagos})", Group: "Preco", SelectionChanged: Radio_SelectionChanged));

            var cursosGratuitos = Items.Count(i => !i.Pago);
            if (cursosGratuitos > 0)
                layoutModalControls.Children.Add(new RadioButtonControl($"Gratuito ({cursosGratuitos})", Group: "Preco", SelectionChanged: Radio_SelectionChanged));

            //Nível
            layoutModalControls.Children.Add(new Label { TextColor = Color.Black, Text = "Nível", FontAttributes = FontAttributes.Bold });
            var níveis = Items.Select(i => i.Nivel).Distinct().OrderByDescending(i => i).ToList();
            foreach (var n in níveis)
            {
                var itemsPorNivel = Items.Count(i => i.Nivel.Equals(n));
                if (itemsPorNivel > 0)
                    layoutModalControls.Children.Add(new RadioButtonControl($"{n} ({itemsPorNivel})", Group: "Nivel", SelectionChanged: Radio_SelectionChanged));
            }

            //Idiomas
            layoutModalControls.Children.Add(new Label { TextColor = Color.Black, Text = "Idioma", FontAttributes = FontAttributes.Bold });
            var idiomas = Items.Select(i => i.Idioma).Distinct().OrderBy(i => i).ToList();
            foreach (var i in idiomas)
            {
                var itemsPorIdioma = Items.Count(x => x.Idioma.Equals(i));
                if (itemsPorIdioma > 0)
                    layoutModalControls.Children.Add(new RadioButtonControl($"{i} ({itemsPorIdioma})", Group: "Idioma", SelectionChanged: Radio_SelectionChanged));
            }
        }

        private void Radio_SelectionChanged(object sender, EventArgs e)
        {
            //var radio = sender as RadioButtonControl;
            ListaAuxiliar.Clear();

            var selectedRadios = layoutModalControls.Children.OfType<RadioButtonControl>().Where(i => i.IsSelected).ToList();
            foreach (var radio in selectedRadios)
            {
                List<CursoSubcategoria> lista = new List<CursoSubcategoria>();
                switch (radio.Group)
                {
                    case "Preco":
                        lista = ListaOriginal.Where(i => i.Pago == (radio.Text.Contains("Pago"))).ToList();
                        ListaAuxiliar.AddRange(lista);
                        break;
                    case "Nivel":
                        lista = ListaOriginal.Where(i => radio.Text.Contains(i.Nivel)).ToList();
                        break;
                    case "Idioma":
                        lista = ListaOriginal.Where(i => radio.Text.Contains(i.Idioma)).ToList();
                        break;
                    default:
                        break;
                }
                ListaAuxiliar.AddRange(lista);
            }

            ListaAuxiliar = ListaAuxiliar.Distinct().ToList();

            if (!ListaAuxiliar.Any())
            {
                ListaAuxiliar.AddRange(ListaOriginal);
            }

            this.lblHeaderModal.Text = ListaAuxiliar.Any() ? $"Cursos {ListaAuxiliar.Count}" : "Nenhum curso encontrado";
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

        private async void Redefinir_Clicked(object sender, EventArgs e)
        {
            ListaAuxiliar.Clear();
            ListaAuxiliar.AddRange(ListaOriginal);
            this.lblHeaderModal.Text = ListaAuxiliar.Any() ? $"Cursos {ListaAuxiliar.Count}" : "Nenhum curso encontrado";
        }

        private async void AplicarFiltros_Clicked(object sender, EventArgs e)
        {
            if (ListBoxOrdenar.SelectedItem == "Preço Menor para Maior")
            {
                Items = new ObservableCollection<CursoSubcategoria>(ListaAuxiliar.OrderBy(i => i.PrecoAtual).ToList());
            }
            else
            {
                Items = new ObservableCollection<CursoSubcategoria>(ListaAuxiliar.OrderByDescending(i => i.PrecoAtual).ToList());
            }
            lstCursos.ItemsSource = Items;
            BindingContext = this;

            layoutModal.IsVisible = false;
            NavigationPage.SetHasNavigationBar(this, true);
        }
    }
}