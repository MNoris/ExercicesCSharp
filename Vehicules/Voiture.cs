using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicules
{
    class Voiture : Véhicule
    {
        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {


        }

        public Voiture(string nom, float prix) : base(nom, 4, prix)
        {


        }

        public override string Description
        {
            get { return "Je suis une voiture \n" + base.Description; }
        }
    }
}
