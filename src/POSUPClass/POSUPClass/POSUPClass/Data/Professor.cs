using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass.Data
{
    public class Professor
    {
        int id;
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        string picture;
        public string Picture
        {
            get { return this.picture; }
            set { this.picture = value; }
        }

        string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        float alunos;
        public float Alunos
        {
            get { return this.alunos; }
            set { this.alunos = value; }
        }

        int cursos;
        public int Cursos
        {
            get { return this.cursos; }
            set { this.cursos = value; }
        }

        string classificacao;
        public string Classificacao
        {
            get { return this.classificacao; }
            set { this.classificacao = value; }
        }

        string description;
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
    }
}
