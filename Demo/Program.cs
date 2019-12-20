using System;

namespace Demo
{
    class Program
    {
        enum Genders {Woman, Man}

        static void Main(string[] args)
        {
            string mot;

            //Appel de la fonction Demo1
            //Demo1();
            //Demo2();
            //Demo3();

            //Console.WriteLine(Hello("Jeanne", 1987, Genders.Woman));
            //Console.WriteLine(Hello("Jean", 1975, Genders.Man));

            mot = Console.ReadLine().ToUpper();
            (int a, int b, int c) p = CountLetters("test");

            //Test(p.a, p.b, p.c);
            


            Console.ReadKey();


        }

        static void Demo1()
        {
            int anneeNais;
            string nom;
            int age;

            Console.Write("Écriture");
            Console.Write(" des mots");
            Console.Write(" les uns à la suite des autres.");
            // Écriture avec retour à la ligne à la fin
            Console.WriteLine("Hello World!");

            Console.WriteLine("Saisissez votre nom : ");
            nom = Console.ReadLine();

            Console.WriteLine("Bonjour " + nom + ", quelle est votre année de naissance ? ");
            anneeNais = Convert.ToInt32(Console.ReadLine());

            // Calcul de l'age en soustrayant l'année de naissance à l'année actuelle
            age = DateTime.Now.Year - anneeNais;

            //Console.WriteLine("Bonjour {0}, vous avez {1} ans", nom, age);

            Console.WriteLine($"Bonjour {nom}, vous avez {age} ans");

            /*
            if(DateTime.IsLeapYear(anneeNais))
                Console.WriteLine("Vous êtes né(e) durant une année bissextile");
            else
                Console.WriteLine("Vous n'êtes pas né(e) durant une année bissextile");*/

            string message;
            message = DateTime.IsLeapYear(anneeNais) ? "Vous êtes né(e) durant une année bissextile" : "Vous n'êtes pas né(e) durant une année bissextile";

            Console.WriteLine(message);
            if (age < 25)
                message = "Vous êtes dans la tranche d'âge : Moins de 25 ans";
            else if (age >= 25 && age < 35)
                message = "Vous êtes dans la tranche d'âge : 25 - 35 ans";
            else
                message = "Vous êtes dans la tranche d'âge : Plus de 35 ans";

            Console.WriteLine(message);

            const int anneeMin = 1900;
            const int anneeMax = 2019;

            if (anneeNais < anneeMin || anneeNais > anneeMax)
                message = "Vous devez saisir une année de naissance valide";

            Console.WriteLine(message);
        }

        static void Demo2()
        {
            string texte;
            string phrase;
            int nbPhrases, nbmots;

            phrase = "Le C# est un langage moderne et puissant";
            texte = phrase;

            //texte = texte + " qui est utilisé pour toutes sortes d'applications \n";
            texte += " qui est utilisé pour toutes sortes d'applications \n";
            texte += " - application console\n";
            texte += " - application fenêtrée avec Winforms & WPF\n";
            texte += " - application mobile avec Xamarin\n";

            Console.WriteLine(texte);

            char lettre;
            lettre = phrase[3];

            int[] tabPos = new int[3];
            tabPos[0] = 3;
            tabPos[1] = 4;
            tabPos[2] = 40;

            tabPos = new int[3] { 3, 4, 40 }; //Syntaxe condensée

            //Retourner le nombre d'éléments dans le tableau
            Console.WriteLine(tabPos.Length);

            for (int i = 0; i < tabPos.Length; i++)
            {
                // Code à exécuter à chaque boucle
                Console.WriteLine($"Position {i} : {tabPos[i]}");
            }

            Console.WriteLine();

            int j = 0;

            //Identique, mais avec While
            while (j < tabPos.Length)
            {
                Console.WriteLine($"Position {j} : {tabPos[j]}");
                j++;
            }

            Console.WriteLine();

            j = 0;

            //Pareil, mais avec Do
            do
            {
                Console.WriteLine($"Position {j} : {tabPos[j]}");
                j++;
            } while (j < tabPos.Length);

            Console.WriteLine();

            foreach (int k in tabPos)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("---------------------------------------");

            nbPhrases = 0;
            for (int i = 0; i < texte.Length; i++)
            {
                if (texte[i].Equals('\n'))
                    nbPhrases++;
            }

            Console.WriteLine($"Il y a {nbPhrases} phrases dans le texte");


        }

        static void Demo3()
        {
            string phrase = "Le C# est un langage moderne et puissant";

            int n = CompterMots(phrase);
            Console.WriteLine($"La phrase \"{phrase}\" comporte {n} mots");
        }

        static int CompterMots(string p)
        {
            int nbMots = 0;

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].Equals(' ') || p[i].Equals('\'') || p[i].Equals('\n'))
                {
                    nbMots++;
                }
            }

            if (nbMots > 1)
            {
                nbMots++;
            }

            return nbMots;
        }

        static string Hello(string name, int year, Genders gender)
        {
            string message = gender == Genders.Woman ? $"Bonjour Madame {name}, vous avez {DateTime.Now.Year - year} ans."
                : $"Bonjour Monsieur {name}, vous avez {DateTime.Now.Year - year} ans.";
            return message;
        }

        static (int letters, int consonants, int vowels) CountLetters(string word)
        {
            int nbVowel = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U' || word[i] == 'Y')
                {
                    nbVowel++;
                }
            }

            return (word.Length, word.Length - nbVowel, nbVowel);
        }

        /*static string Test(int letters, int consonants, int vowels)
        {
            string message = $" comporte {letters} lettres, dont {consonants} consonnes et {vowels} voyelles.";

            return message;
        }*/

    }
}
