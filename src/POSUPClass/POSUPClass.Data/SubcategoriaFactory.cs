using POSUPClass.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass.Data
{
    public class SubcategoriaFactory
    {
        public static List<Subcategoria> Subcategorias { get; private set; }

        public static void Initialize()
        {
            Subcategorias = new List<Subcategoria>();

            //Negócios
            Subcategorias.Add(new Subcategoria { Id = 1670, Nome = "Finanças", Arquivo = "financas.json" });
            Subcategorias.Add(new Subcategoria { Id = 1672, Nome = "Empreendedorismo", Arquivo = "empreendedorismo.json" });
            Subcategorias.Add(new Subcategoria { Id = 1674, Nome = "Comunicações", Arquivo = "comunicacoes.json" });
            Subcategorias.Add(new Subcategoria { Id = 1676, Nome = "Administração", Arquivo = "administracao.json" });
            Subcategorias.Add(new Subcategoria { Id = 1678, Nome = "Vendas", Arquivo = "vendas.json" });
        }
    }
}
