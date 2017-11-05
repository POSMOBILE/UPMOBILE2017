using POSUPClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass.Factory
{
    public class SubcategoriaFactory
    {
        public static List<Subcategoria> Subcategorias { get; private set; }

        public static void Initialize()
        {
            Subcategorias = new List<Subcategoria>();

            //Negócios
            Subcategorias.Add(new Subcategoria { Id = 1670, Nome = "Finanças", Arquivo = "POSUPClass.Json.financas.json" });
            Subcategorias.Add(new Subcategoria { Id = 1672, Nome = "Empreendedorismo", Arquivo = "POSUPClass.Json.empreendedorismo.json" });
            Subcategorias.Add(new Subcategoria { Id = 1674, Nome = "Comunicações", Arquivo = "POSUPClass.Json.comunicacoes.json" });
            Subcategorias.Add(new Subcategoria { Id = 1676, Nome = "Administração", Arquivo = "POSUPClass.Json.administracao.json" });
            Subcategorias.Add(new Subcategoria { Id = 1678, Nome = "Vendas", Arquivo = "POSUPClass.Json.vendas.json" });
        }
    }
}
