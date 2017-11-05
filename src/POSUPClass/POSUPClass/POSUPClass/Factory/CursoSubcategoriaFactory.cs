using Newtonsoft.Json;
using POSUPClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass.Factory
{
    public class CursoSubcategoriaFactory
    {
        public static List<CursoSubcategoria> Cursos { get; private set; }

        public static void Initialize()
        {
            Cursos = new List<CursoSubcategoria>();

            foreach (var sub in SubcategoriaFactory.Subcategorias)
            {
                var stream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream(sub.Arquivo);
                using (var reader = new System.IO.StreamReader(stream, Encoding.GetEncoding("iso-8859-1")))
                {
                    var str = reader.ReadToEnd();
                    var cursos = JsonConvert.DeserializeObject<List<CursoSubcategoria>>(str);
                    foreach (var item in cursos)
                    {
                        item.IdSubcategoria = sub.Id;
                    }
                    Cursos.AddRange(cursos);
                }
            }
        }
    }
}
