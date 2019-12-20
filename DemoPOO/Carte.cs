using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPOO
{
    class Carte
    {
        public int Numéro { get; set; }
        public int CodeSecret { get; set; }
        public int Cryptogramme { get; set; }
        public DateTime DateExpiration { get; set; }

        public Carte()
        {

        }

        public Carte(int num) : this()
        {
            Numéro = num;
        }
    }
}
