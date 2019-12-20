using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPOO
{
    class CompteBancaire
    {
        private static int _compteur;

        public static int Compteur { get { return _compteur; } }

        public long Numéro { get; }
        public DateTime DateCreation { get; }

        public decimal Solde
        {
            get;
            private set;
        }

        public string Description { get; set; }

        public CompteBancaire(long num)
        {
            Numéro = num;
            _compteur++;
        }

        public CompteBancaire(long num, DateTime dateCrea) : this(num)
        {
            DateCreation = dateCrea;
        }

        public void Créditer(decimal montant)
        {
            Solde += montant;
        }

        public void Créditer(decimal montant, string description)
        {
            Créditer(montant);
            Description = description;
        }

        public void Débiter(decimal montant)
        {
            if (true)
            {
                Solde -= montant;
            }
        }
    }
}
