using System;

namespace Boites
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box box1 = new Box(30, 30, 30, Matters.Carton);
            //Box box2 = new Box(30, 37, 32, Matters.Métal);
            //Box box3 = new Box(30, 30, 30, Matters.Carton);

            //Console.WriteLine(box1.Equals(box2));
            //Console.WriteLine(box1.Equals(box3));

            //Console.WriteLine($"{Box.Compteur} boites ont été créées");

            ////box1.Etiqueter("Dupont");
            //box1.Etiqueter("Dupont", true);
            
            Box boxF = new Box(30, 40, 50, Matters.Plastique);
            Etiquette etiquette = new Etiquette { Color = Colors.Blanc, Format = Formats.L, Text = "Mon moi du futur" };
            Etiquette etiquette2 = new Etiquette { Color = Colors.Rouge, Format = Formats.S, Text = "FRAGILE" };

            boxF.Etiqueter(etiquette, etiquette2);
            Console.WriteLine(boxF);
        }
    }
}
