using POSUPClass.model;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POSUPClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeusCursos : ContentPage
    {
        ObservableCollection<Curso> listaCursos = new ObservableCollection<Curso>();

        public MeusCursos()
        {
            InitializeComponent();
            ListarCursos();
            cursos.ItemsSource = listaCursos;
        }

        public void ListarCursos()
        {
            listaCursos.Add(montarCurso("Desenvolvedor Multiplataforma Android/IOS com React e Redux", "Alessandro Oliveira", "0% Concluído", "", "https://cdn-images-1.medium.com/max/698/1*m_q0YKyWw7Qqbh-qklinTw.png"));

            listaCursos.Add(montarCurso("Curso Completo do Desenvolvedor", "Alessandro Oliveira", "0 % Concluído", "", "http://projetodraft.com/draft/wp-content/uploads/2017/08/full-stacker-871x570.jpg"));

            listaCursos.Add(montarCurso("Learn Angular from Benninger to Advanced", "Alessandro Oliveira", "0 % Concluído", "", "https://upload.wikimedia.org/wikipedia/commons/f/f1/Ruby_logo_64x64.png"));

            listaCursos.Add(montarCurso("Advance Android Programming - learning beyond basics", "Alessandro Oliveira", "12% Concluído" , "", "https://developer.android.com/_static/images/android/touchicon-180.png"));
        }

        public Curso montarCurso(String nome, String autores, String Percentual, String Descricao, String url)
        {
            Curso curso = new Curso();
            curso.Nome = nome;
            curso.Autores = autores;
            curso.Percentual = Percentual;
            curso.Descricao = Descricao;
            curso.Url = url;

            return curso;
        }
    }

}