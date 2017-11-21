using Xamarin.Forms;
using System.Collections.Generic;
using POSUPClass.Model;

namespace POSUPClass
{

    public partial class ListaDeDesejos : ContentPage
    {
        public ListaDeDesejos()
        {
            InitializeComponent();
            desejos.ItemsSource = new List<Desejo>
            {
                new Desejo {NomeCurso="Curso de Rails", Professor="Professor Jose", PrecoInfo="R$ 1200.00 (R̶$̶1̶̶̶8̶̶̶0̶̶̶0̶̶̶.̶̶̶0̶̶̶0̶̶̶)", QuantidadePontos="(1000)", FotoCursoUrl="https://upload.wikimedia.org/wikipedia/commons/f/f1/Ruby_logo_64x64.png", EstrelaUrl="http://clipart-library.com/images/6ip6dAbiE.png"},
                new Desejo {NomeCurso="Curso de Java", Professor="Professor Marcos", PrecoInfo="R$ 500.00 (R̶$̶7̶0̶0̶,̶0̶0̶)", QuantidadePontos="(1020)", FotoCursoUrl="http://certificate.fyicenter.com/z/_icon_Java_VM.png", EstrelaUrl="http://clipart-library.com/images/6ip6dAbiE.png"},
                new Desejo {NomeCurso="Curso de Php", Professor="Professor João", PrecoInfo="R$ 300.00 (R̶$̶5̶0̶0̶,̶0̶0̶)", QuantidadePontos="(880)", FotoCursoUrl="https://www.codester.com/static/uploads/categories/10/icon.png", EstrelaUrl="http://clipart-library.com/images/6ip6dAbiE.png"},
                new Desejo {NomeCurso="Curso de SQLServer", Professor="Professora Maria", PrecoInfo="R$ 1200.00 (R̶$̶1̶̶̶8̶̶̶0̶̶̶0̶̶̶.̶̶̶0̶̶̶0̶̶̶)", QuantidadePontos="(1000)", FotoCursoUrl="https://disenowebakus.net/imagenes/articulos/iconos/html5.jpg", EstrelaUrl="http://clipart-library.com/images/6ip6dAbiE.png"},
                new Desejo {NomeCurso="Curso de ASP.NET", Professor="Professora Sonia", PrecoInfo="R$ 1200.00 (R̶$̶1̶̶̶8̶̶̶0̶̶̶0̶̶̶.̶̶̶0̶̶̶0̶̶̶)", QuantidadePontos="(1000)", FotoCursoUrl="http://csharpcorner.mindcrackerinc.netdna-cdn.com/UploadFile/MinorCatImages/asp-dot-net-programming_025049707.png", EstrelaUrl="http://clipart-library.com/images/6ip6dAbiE.png"},
            };
        }
    }
}