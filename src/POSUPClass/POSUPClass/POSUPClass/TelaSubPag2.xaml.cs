using POSUPClass.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POSUPClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaSubPag2 : ContentPage
    {
        public ObservableCollection<ElementsViewModel> elements { get; set; }

        public class Dados
        {
            public string img { get; set; }
            public string texto { get; set; }
        }

        List<Dados> lista;

        public TelaSubPag2()
        {
            InitializeComponent();

            lista = new List<Dados>();

            lista.Add(new Dados { img = "angular.png" });
            lista.Add(new Dados { img = "app.png" });
            lista.Add(new Dados { img = "aprenda_angular.png" });
            lista.Add(new Dados { img = "banco_de_dados.png" });
            lista.Add(new Dados { img = "unreal.png" });
            lista.Add(new Dados { img = "ruby.png" });
            lista.Add(new Dados { img = "curso_completo.png" });
            lista.Add(new Dados { img = "react.png" });
            lista.Add(new Dados { img = "ios_11.png" });
            lista.Add(new Dados { img = "mongo.png" });
            lista.Add(new Dados { img = "php.png" });
            lista.Add(new Dados { img = "python.png" });
            lista.Add(new Dados { img = "ios.png" });
            lista.Add(new Dados { img = "curso_desenvolvedor.png" });
            lista.Add(new Dados { img = "docker.png" });
            lista.Add(new Dados { img = "ionic.png" });
            lista.Add(new Dados { img = "c_sharp.png" });
            lista.Add(new Dados { img = "kotlin.png" });

            MainCarouselView.ItemsSource = lista;

            //  TelaSubPag2 = new SpeakerView();

            elements = new ObservableCollection<ElementsViewModel>();
            elements.Add(new ElementsViewModel
            {
                Image = "www.png",
                Name = " ",
                Type = "Desenvolvimento Web"
            });

            elements.Add(new ElementsViewModel
            {
                Image = "smart.png",
                Name = " ",
                Type = "Aplicativos Móveis"
            });

            elements.Add(new ElementsViewModel
            {
                Image = "linguagem.png",
                Name = " ",
                Type = "Linguagens de Programação"
            });

            elements.Add(new ElementsViewModel
            {
                Image = "games.png",
                Name = " ",
                Type = "Desenvolvimento de games"
            });

            elements.Add(new ElementsViewModel
            {
                Image = "banco.png",
                Name = " ",
                Type = "Banco de dados"
            });

            elements.Add(new ElementsViewModel
            {
                Image = "e_commerce.png",
                Name = " ",
                Type = "E-Commerce"
            });

            elements.Add(new ElementsViewModel
            {
                Image = "engenharia.png",
                Name = " ",
                Type = "Emgenharia de Software"
            });

            elements.Add(new ElementsViewModel
            {
                Image = "ferramenta.png",
                Name = " ",
                Type = "Ferramenta de Desenvolvimento"
            });


            listView.ItemsSource = elements;
        }
    }
}