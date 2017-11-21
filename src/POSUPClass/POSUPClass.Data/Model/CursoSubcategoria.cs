using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass.Data.Model
{
    public class CursoSubcategoria
    {
        public int Id { get; set; }

        public int IdSubcategoria { get; set; }

        public String Nome { get; set; }

        public String Instrutores { get; set; }

        public double Estrelas { get; set; }

        public int Reviews { get; set; }

        public decimal PrecoAtual { get; set; }

        public decimal PrecoAntigo { get; set; }

        public bool Pago { get; set; }

        public int Nivel { get; set; }

        public String Idioma { get; set; }
    }
}