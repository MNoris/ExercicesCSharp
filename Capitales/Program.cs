using System;

namespace Capitales
{
    class Program
    {
        static string[] countries = {"Albanie", "Allemagne", "Andorre", "Autriche", "Belgique", "Biélorussie", "Bosnie-Herzégovine",
                "Bulgarie", "Chypre", "Croatie", "Danemark", "Espagne", "Estonie", "Finlande", "France", "Grèce", "Hongrie",
                "Irlande", "Islande", "Italie", "Kazakhstan", "Kosovo", "Lettonie", "Liechtenstein", "Lituanie", "Luxembourg", "Macédoine",
                "Malte", "Moldavie", "Monaco", "Monténégro", "Norvège", "Pays-Bas", "Pologne", "Portugal", "Roumanie", "Royaume-Uni",
                "Russie", "Serbie", "Slovaquie", "Slovénie", "Suisse", "Suède", "République tchèque", "Ukraine"};
        static string[] capitals = {"Tirana", "Berlin", "Andorre-la-Vieille", "Vienne", "Bruxelles", "Minsk", "Sarajevo", "Sofia", "Nicosie", "Zagreb", "Copenhague", "Madrid",
                "Tallinn", "Helsinki", "Paris", "Athènes", "Budapest", "Dublin", "Reykjavik", "Rome", "Astana", "Pristina", "Riga", "Vaduz", "Vilnius",
                "Luxembourg", "Skopje", "La Valette", "Chisinau", "Monaco", "Podgorica", "Oslo", "Amsterdam", "Varsovie", "Lisbonne", "Bucarest", "Londres",
                "Moscou", "Belgrade", "Bratislava", "Ljubljana", "Berne", "Stockholm", "Prague", "Kiev"};

        static void Main(string[] args)
        {
            //string replay = "o";

            //while (replay.Equals("o"))
            //{
            //    replay = Play().ToLower();
            //    Console.Clear();
            //}

            //Console.WriteLine("Merci d'avoir joué");
            //Console.ReadLine();

            Play2();
        }

        //static string Play()
        //{
        //int goodAnswers = 0;

        //Étape 7
        //for (int i = 9; i >= 0; i-- )

        //Parcourir les 10 premières entrées du tableau /* Étape 6 commentée */
        //for (int i = 0; i < 10; i++ /*i += 2*/)
        //{
        //    if (PoserQuestion(i))
        //    {
        //        goodAnswers++;
        //    }
        //}

        //Console.WriteLine(goodAnswers);

        //Console.WriteLine("Voulez vous rejouer ? (o / O pour rejouer)");
        //return Console.ReadLine().ToLower();
        //}

        static bool AskQuestion(int indice)
        {
            bool isGood;
            string answer;

            Console.WriteLine($"Quelle est la capitale du pays suivant : {countries[indice]}");
            answer = Console.ReadLine().ToLower();

            

            if (answer.Equals(capitals[indice].ToLower()))
            {
                Console.WriteLine("Bravo !");
                isGood = true;
            }
            else
            {

                Console.WriteLine($"Mauvaise réponse. La réponse était {capitals[indice]}");
                isGood = false;
            }

            return isGood;
        }
        static void Play2()
        {
            Random rand = new Random();
            int goodAnswers = 0;
            string message;

            do
            {
                Console.Clear();
                Console.WriteLine("\nAppuyer sur Echap pour arrêter le jeu");

                message = goodAnswers > 1 ? $"{goodAnswers} bonnes réponses." : $"{goodAnswers} bonne réponse.";
                Console.WriteLine(message);

                if (AskQuestion(rand.Next(45)))
                {
                    goodAnswers++;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("æ");
            Console.WriteLine("Merci d'avoir joué !");
        }
    }
}
