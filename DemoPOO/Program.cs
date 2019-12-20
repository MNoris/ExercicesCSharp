using System;

namespace DemoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2019, 11, 15);
            CompteBancaire cb = new CompteBancaire(515610451);

            CompteBancaire cb2 = new CompteBancaire(145641152, dt);

            cb2.Créditer(123);
            cb2.Créditer(456, "Virement salaire.");

            Console.WriteLine($"Solde du compte {cb.Numéro} : {cb.Solde} Euros");
            Console.WriteLine($"Dernière opération {cb.Description}");

            int cpt = CompteBancaire.Compteur;
            Console.WriteLine($"{cpt} comptes bancaires ont été créés");

            //----------------------------------------------------//

            Carte c1 = new Carte();
            c1.Numéro = 15686456;
            c1.CodeSecret = 1561;
            c1.Cryptogramme = 123;
            c1.DateExpiration = new DateTime(2021, 12, 31);

            Carte c2 = new Carte { Numéro = 1561865, CodeSecret = 4567 };
            Carte c3 = new Carte(156478) {CodeSecret = 289 };


            Console.ReadKey();
        }
    }
}
