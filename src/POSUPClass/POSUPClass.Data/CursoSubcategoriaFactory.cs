using POSUPClass.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass.Data
{
    public class CursoSubcategoriaFactory
    {
        public static List<CursoSubcategoria> Cursos { get; private set; }

        public static void Initialize(List<Subcategoria> subcategorias, Type type)
        {
            Cursos = new List<CursoSubcategoria>();

            foreach (var sub in subcategorias)
            {
                ApplicationData
                var assembly = type.GetTypeInfo().Assembly;
                var stream = assembly.GetManifestResourceStream(sub.Arquivo);
            }
        }
    }
}
