using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Panier
{
    public class LignPanier
    {
        public int IdBook { get; set; }
        public double PrixBook { get; set; }
        public int Quantite { get; set; }
        public double Total { get { return Quantite * PrixBook; } }
        public string Description { get; set; } = string.Empty;
        public string NomImage { get; set; } = string.Empty;

    }
}