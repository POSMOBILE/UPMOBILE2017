using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass.Data
{
    public class ProfessorPerfilCursos
    {
        int id;
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        int idProf;
        public int IdProf
        {
            get { return this.idProf; }
            set { this.idProf = value; }
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

        int stars;
        public int Stars
        {
            get { return this.stars; }
            set { this.stars = value; }
        }

        int votes;
        public int Votes
        {
            get { return this.votes; }
            set { this.votes = value; }
        }

        double discount;
        public double Discount
        {
            get { return this.discount; }
            set { this.discount = value; }
        }
        
        double price;
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
