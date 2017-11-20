using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass.Data
{
    public class ProfessorPerfilContatos
    {
        string picture;
        public string Picture
        {
            get { return this.picture; }
            set { this.picture = value; }
        }

        string social;
        public string Social
        {
            get { return this.social; }
            set { this.social = value; }
        }

        string url;
        public string Url
        {
            get { return this.url; }
            set { this.url = value; }
        }
    }
}
