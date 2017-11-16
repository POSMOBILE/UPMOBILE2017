using projeto_teste_lenon.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projeto_teste_lenon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaOpinioes : ContentPage
    {
        public ObservableCollection<ElementoOpinioes> elementos { get; set; }

        public TelaOpinioes()
        {

            InitializeComponent();

            elementos = new ObservableCollection<ElementoOpinioes>();
            elementos.Add(new ElementoOpinioes
            {
                Estrela = "estrela_1.png",
                Nome = "Warley Ferreira Silva",
                Dias = "3",
                Hora = "20:52",
                Opinioes = "Ainda foi pouco conteudo até aqui, " +
                "mas as vezes o instrutor não passa muita confiança " +
                "na sua fala"
            });

            elementos.Add(new ElementoOpinioes
            {
                Estrela = "estrela_2.png",
                Nome = "Lucas Rezendo do Nascimento",
                Dias = "4",
                Hora = "00:27",        
                Opinioes = "Curso muito bom, mas senti falta de alguns detalhes sobre " +
                "notificação usando o Xamarin"
            });
            elementos.Add(new ElementoOpinioes
            {
                Estrela = "estrela_3.png",
                Nome = "Luciano da Silva Dória",
                Dias = "5",
                Hora = "09:25",          
                Opinioes = "Aulas didaticas, bem explicadas e com atualizações de vídeos " +
                "aulas assim que tem novas versões do Xamarin"
            });
            elementos.Add(new ElementoOpinioes
            {
                Estrela = "estrela_3.png",
                Nome = "Mauricio Vieira dos Santos",
                Dias = "8",
                Hora = "18:59",
                Opinioes = "Curso muito bom pra quem quer conhecer o Xamarim"
            });

            elementos.Add(new ElementoOpinioes
            {
                Estrela = "estrela_2.png",
                Nome = "Ricaro dos Santos",
                Dias = "8",
                Hora = "17:51",
                Opinioes = "Curso muito bom pra quem quer conhecer o Xamarim"
            });

            elementos.Add(new ElementoOpinioes
            {
                Estrela = "estrela_1.png",
                Nome = "Fernando de Souza",
                Dias = "8",
                Hora = "17:01",
                Opinioes = "Curso muito bom pra quem quer conhecer o Xamarim"
            });
            listView.ItemsSource = elementos;

        }
    }
}