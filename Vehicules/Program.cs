using System;
using System.Collections.Generic;

namespace Vehicules
{
    class Program
    {
        static void Main(string[] args)
        {
            //Voiture v = new Voiture("Test", Energies.Electrique);

            //Console.WriteLine(v.Description);

            Véhicule Meg = new Voiture("Mégane", 19000);
            Véhicule Enz = new Voiture("Enzo", 380000);
            Véhicule Intru = new Moto("Intruder", 13000);
            Véhicule Yama = new Moto("Yamaha XJR1300", 11000);

            var liste1 = new SortedList<string, Véhicule>();
            liste1.Add(Meg.Nom, Meg);
            liste1.Add(Enz.Nom, Enz);
            liste1.Add(Intru.Nom, Intru);
            liste1.Add(Yama.Nom, Yama);

            foreach (var item in liste1)
            {
                Console.WriteLine($"{item.Key} : {item.Value.Prix}");
            }

            //Par ordre alphabétique

            Console.WriteLine("------------------------");

            var liste2 = new SortedList<Véhicule, string>();
            liste2.Add(Meg, Meg.Nom);
            liste2.Add(Enz, Enz.Nom);
            liste2.Add(Intru, Intru.Nom);
            liste2.Add(Yama, Yama.Nom);

            foreach (var item in liste2)
            {
                Console.WriteLine($"{item.Key.Nom} : {item.Key.Prix}");
            }

            //Par prix croissant

            //Ça plante, clé déjà existante

            Console.WriteLine("------------------------");

            string[] tab = new string[] { "Clio", "Mégane", "Golf", "Enzo", "Polo" };
            foreach (var item in tab)
            {
                if (liste1.TryGetValue(item, out Véhicule v))
                    Console.WriteLine($"{v.Nom} : {v.Prix}");
            }

            Console.WriteLine();
        }
    }
}
