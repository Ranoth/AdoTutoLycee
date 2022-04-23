using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoTutoLycee
{
    public class Livre
    {
        public int Num { get; set; }
        public string ISBN { get; set; }
        public string Titre { get; set; }
        public float Prix { get; set; }
        public string Editeur { get; set; }
        public int Annee { get; set; }
        public string Langue { get; set; }
        public int NumAuteur { get; set; }
        public int NumGenre { get; set; }
    }
}
