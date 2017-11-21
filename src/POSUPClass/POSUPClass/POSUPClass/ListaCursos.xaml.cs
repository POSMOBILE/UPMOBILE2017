using POSUPClass.model;
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
    public partial class ListaCursos : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListaCursos()
        {
            InitializeComponent();

            cursos.ItemsSource = new System.Collections.Generic.List<Cursos>
            {
                new Cursos {NomeCurso="Curso HTML5", Professor="Professor 1", Preco="R$ 1200.00 (R̶$̶1̶̶̶8̶̶̶0̶̶̶0̶̶̶.̶̶̶0̶̶̶0̶̶̶)", Review="Review 1000", ImgCurso="https://udemy-images.udemy.com/course/750x422/997144_1357_2.jpg", EstrelaUrl="http://clipart-library.com/images/6ip6dAbiE.png"},
                new Cursos {NomeCurso="Curso Xamarin", Professor="Professor 2", Preco="R$ 300.00 (R̶$̶5̶0̶0̶,̶0̶0̶)", Review="Review 880", ImgCurso="https://udemy-images.udemy.com/course/750x422/921268_2f01_7.jpg", EstrelaUrl="http://clipart-library.com/images/6ip6dAbiE.png"},
                new Cursos {NomeCurso="Curso Java", Professor="Professora 3", Preco="R$ 1200.00 (R̶$̶1̶̶̶8̶̶̶0̶̶̶0̶̶̶.̶̶̶0̶̶̶0̶̶̶)", Review="Review 1000", ImgCurso="https://udemy-images.udemy.com/course/480x270/1164288_ed0c_3.jpg", EstrelaUrl="http://clipart-library.com/images/6ip6dAbiE.png"},
                new Cursos {NomeCurso="Curso CSS3", Professor="Professor 4", Preco="R$ 500.00 (R̶$̶7̶0̶0̶,̶0̶0̶)", Review="Review 1020", ImgCurso="https://udemy-images.udemy.com/course/750x422/997144_1357_2.jpg", EstrelaUrl="http://clipart-library.com/images/6ip6dAbiE.png"},
                new Cursos {NomeCurso="Curso PHP", Professor="Professora 5", Preco="R$ 1200.00 (R̶$̶1̶̶̶8̶̶̶0̶̶̶0̶̶̶.̶̶̶0̶̶̶0̶̶̶)", Review="Review  1000", ImgCurso="http://padhana.com/timthumb.php?src=http://padhana.com/image/question_papers/thumb_paper_1_php.jpg&w=370&h=250", EstrelaUrl="http://clipart-library.com/images/6ip6dAbiE.png"},
            };
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
