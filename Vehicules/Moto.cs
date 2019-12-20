using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicules
{
    class Moto : Véhicule
    {
        public override string Description => "Je suis une moto \n" + base.Description;

        public Moto(string nom, Energies energie) : base(nom, 2, energie)
        {

        }

        public Moto(string nom, float prix) : base(nom, 4, prix)
        {


        }
    }
}
