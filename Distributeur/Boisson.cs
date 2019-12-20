using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur
{
    class Boisson
    {
        public Boissons Nom { get; set; }
        public float Prix { get; set; }

        public Boisson(Boissons nom, float prix)
        {
            Nom = nom;
            Prix = prix;
        }

        public Boisson()
        {
            
        }
    }
}
