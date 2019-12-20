using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicules
{
    class Véhicule : IComparable<Véhicule>
    {
        public string Nom { get; }
        public int NbRoues { get; }
        public Energies Energie { get; }
        public float Prix { get; set; }
        public virtual string Description
        {
            get
            {
                return $"Véhicule {Nom} roule sur {NbRoues} roues et à l'énergie {Energie}.";
            }
        }
        
        public Véhicule(string nom, int roues, Energies energie)
        {
            Nom = nom;
            NbRoues = roues;
            Energie = energie;
        }

        public Véhicule(string nom, int roues, float prix)
        {
            Nom = nom;
            NbRoues = roues;
            Prix = prix;
        }

        public int CompareTo(Véhicule v)
        {
            if (Prix > v.Prix)
                return 1;
            else if (Prix < v.Prix)
                return -1;
            return 0;
        }
    }
}
