using System;
using System.Collections.Generic;
using System.Text;

namespace Distributeur
{
    class Distributeur
    {
        public Boisson[] BoissonsDispo { get; set; }

        public Distributeur(Boisson[] boissonsDispo)
        {
            BoissonsDispo = boissonsDispo;
        }

        public void ServirBoisson(Boissons bois, float solde)
        {
            int sucre = 3;
            float prix = 0;
            foreach (Boisson item in BoissonsDispo)
            {
                if (bois == item.Nom)
                {
                    prix = item.Prix;
                    string s = null;
                }                
            }
            if (solde < prix)
            {
                throw new ArgumentOutOfRangeException("");
            }
        }

        public void ServirBoisson(Boissons bois, int sucre, float solde)
        {

            
        }        
    }
}
