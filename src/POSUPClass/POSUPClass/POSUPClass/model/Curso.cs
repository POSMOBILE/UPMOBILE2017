using System;

namespace POSUPClass.Model
{
    public class Curso
    {
        public string Nome { get; set; }
        public string Autores { get; set; }
        public string Percentual { get; set; }
        public string Descricao { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return Nome + ". Autores: " + Autores + Url + Percentual;
        }
    }
}
