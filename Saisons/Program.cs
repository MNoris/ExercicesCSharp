using System;

namespace MoisSaisons
{
    [Flags]
    public enum Saisons
    {
        Aucun = 0,
        Hiver = 1,
        Printemps = 2,
        Eté = 4,
        Automne = 8
    }

    [Flags]
    public enum Mois
    {
        Aucun = 0,
        Janvier = 1,
        Février = 2,
        Mars = 4,
        Avril = 8,
        Mai = 16,
        Juin = 32,
        Juillet = 64,
        Aout = 128,
        Septembre = 256,
        Octobre = 512,
        Novembre = 1024,
        Décembre = 2048
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(SaisonsDuMois(Mois.Juin));
        }

        static Saisons SaisonsDuMois(Mois mois)
        {
            Mois Hiver = Mois.Décembre | Mois.Janvier | Mois.Février | Mois.Mars;
            Mois Printemps = Mois.Mars | Mois.Avril | Mois.Mai | Mois.Juin;
            Mois Eté = Mois.Juin | Mois.Juillet | Mois.Aout | Mois.Septembre;
            Mois Automne = Mois.Septembre | Mois.Octobre | Mois.Novembre | Mois.Décembre;

            Saisons saisonsDuMois = 0;

            if ((mois & Hiver) == mois)
                saisonsDuMois |= Saisons.Hiver;

            if ((mois & Printemps) == mois)
                saisonsDuMois |= Saisons.Printemps;

            if ((mois & Eté) == mois)
                saisonsDuMois |= Saisons.Eté;

            if ((mois & Automne) == mois)
                saisonsDuMois |= Saisons.Automne;
            
            return saisonsDuMois;
        }
    }
}
