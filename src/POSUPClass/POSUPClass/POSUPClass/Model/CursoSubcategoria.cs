using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass.Model
{
    public class CursoSubcategoria
    {
        public int Id { get; set; }

        public int IdSubcategoria { get; set; }

        public String Nome { get; set; }

        public List<String> Instrutores { get; set; }

        public float Estrelas { get; set; }

        public int Reviews { get; set; }

        public String PrecoAtual { get; set; }

        public String PrecoAntigo { get; set; }

        public bool Pago { get; set; }

        public String Nivel { get; set; }

        public String Idioma { get; set; }

        public String ImagemUrl { get; set; }

        public String DescInstrutores { get { return Instrutores != null ? String.Join(", ", Instrutores) : ""; } }

        public String Preco { get { return $"{PrecoAtual} {PrecoAntigo}"; } }
    }

}