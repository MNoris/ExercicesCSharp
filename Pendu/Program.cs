using System;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jouez au pendu!");

            //--------------------------------------------------------------------------
            // 1. Les étapes ci-desous consistent à faire saisir un mot valide au 1er joueur

            string message;
            string mot = string.Empty;
            bool motValide = false;
            // Tant que le mot saisi n'est pas valide
            while (!motValide)
            {
                message = string.Empty;
                mot = string.Empty;

                // On fait saisir le mot
                mot = Console.ReadLine();

                try
                {
                    // On vérifie son format (appeler la méthode statique VerifierMot)
                    Jeu.VerifierMot(mot.ToLower());
                } catch(FormatException e)
                {
                    message = e.Message;
                }

                if (message.Equals(""))
                {
                    motValide = true;
                } else {
                    Console.WriteLine(message);
                }                        
            }

            //--------------------------------------------------------------------------
            // 2. les étapes suivantes consistent à faire deviner le mot au 2d joueur

            // On vide l'écran
            Console.Clear();

            // On crée un jeu et on l'initialise avec le mot saisi
            Jeu jeu = new Jeu();
            jeu.InitialiserJeu(mot);

            // Tant que le jeu n'est pas fini
            while (jeu.EtatPartie == EtatsPartie.EnCours)
            {
                // On affiche le dessin et l'état du mot en cours
                Console.WriteLine(jeu.DessinPendu);
                Console.WriteLine(jeu.MotEnCours);

                // On demande une lettre et on la teste
                Console.Write("Proposez une lettre : ");
                char lettre = Console.ReadKey().KeyChar;
                jeu.TesterLettre(lettre);
            }

            // Si la partie est gagnée, on affiche un message en vert
            if (jeu.EtatPartie == EtatsPartie.Gagnée)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nVous avez gagné en devinant le mot \"{mot}\".");
            }

            // Si elle est perdue on affiche un message en rouge avec la solution
            if (jeu.EtatPartie == EtatsPartie.Perdue)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(jeu.DessinPendu);

                Console.WriteLine($"\nVous avez perdu. Le mot était \"{mot}\".");
            }

            Console.ReadKey();
        }
    }
}
