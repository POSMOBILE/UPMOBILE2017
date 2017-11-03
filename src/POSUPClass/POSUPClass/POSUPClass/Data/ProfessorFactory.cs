using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass.Data
{
    public static class ProfessorFactory
    {
        public static Professor Prof { get; private set; }
        public static IList<ProfessorPerfilCursos> ProfCursos { get; private set; }
        public static IList<ProfessorPerfilContatos> ProfContatos { get; private set; }

        static ProfessorFactory()
        {
            ProfCursos = new ObservableCollection<ProfessorPerfilCursos>
            {
                new ProfessorPerfilCursos
                {
                    Id = 1,
                    IdProf = 1,
                    Name = "Python 3 para iniciantes",
                    Picture = "python.png",
                    Stars = 4,
                    Votes = 480,
                    Discount = 37.99,
                    Price = 63.00
                },
                new ProfessorPerfilCursos
                {
                    Id = 2,
                    IdProf = 1,
                    Name = "C++ para iniciantes",
                    Picture = "cpp.png",
                    Stars = 2,
                    Votes = 338,
                    Discount = 42.99,
                    Price = 78.00
                },
                new ProfessorPerfilCursos
                {
                    Id = 3,
                    IdProf = 1,
                    Name = "PHP Laravel para iniciantes",
                    Picture = "php.jpg",
                    Stars = 5,
                    Votes = 922,
                    Discount = 27.99,
                    Price = 40.00
                },
                new ProfessorPerfilCursos
                {
                    Id = 4,
                    IdProf = 1,
                    Name = "NodeJS para iniciantes",
                    Picture = "nodejs.png",
                    Stars = 3,
                    Votes = 127,
                    Discount = 30.99,
                    Price = 52.00
                },
            };

            Prof = new Professor
            {
                Id = 1,
                Picture = "marcoscastro.jpg",
                Name = "Marcos Castro",
                Alunos = 27.469f,
                Cursos = 35,
                Classificacao = "4.00/5",
                Description = "Marcos Castro é graduado em Engenharia Elétrica pela Universidade Federal do Ceará e Mestre em Informática Aplicada."
            };

            ProfContatos = new ObservableCollection<ProfessorPerfilContatos>
            {
                new ProfessorPerfilContatos
                {
                    Picture = "youtube.png",
                    Social = "Youtube",
                    Url = "https://www.youtube.com/aulasdeprogramacao"
                },
                new ProfessorPerfilContatos
                {
                    Picture = "twitter.png",
                    Social = "Twitter",
                    Url = "https://twitter.com/marcoscastro"
                },
                new ProfessorPerfilContatos
                {
                    Picture = "facebook.png",
                    Social = "Facebook",
                    Url = "https://www.facebook.com/marcos.castro"
                },
            };
        }
    }
}
