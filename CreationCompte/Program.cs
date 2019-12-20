using System;

namespace CreationCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            CréerCompte();            


            //CheckPswd("Helloo");

        }

        static void CréerCompte()
        {
            Console.WriteLine("Veuillez saisir votre login, puis un mot de passe.");
            string login = Console.ReadLine();
            string pswd = Console.ReadLine();

            //try
            //{
            //    CheckLogin(login);
            //    CheckPswd(pswd);

            //    Console.WriteLine("Votre compte a bien été créé. Un message vient de vous être envoyé");
            //}
            //catch (FormatException f)
            //{
            //    Console.WriteLine(f.Message);
            //}
        }

        static void CheckLogin(string login)
        {
            if (login.Length < 5)
            {
                throw new FormatException("Le login doit avoir au moins 5 caractères.");
            }
        }

        static void CheckPswd(string pswd)
        {
            bool hasLetter = false, hasNumber = false;

            if (pswd.Length < 6)
            {
                throw new FormatException("Le mot de passe doit avoir au moins 6 caractères");
            }

            foreach (char c in pswd)
            {
                if (c >= 48 & c <= 57)
                {
                    hasNumber = true;
                }
                if ((c >= 65 & c <= 90) || (c >= 97 & c <= 122))
                {
                    hasLetter = true;
                }
            }

            if (!hasLetter || !hasNumber)
            {
                throw new FormatException("Le mot de passe doit avoir au moins une lettre et au moins un chiffre.");
            }
        }
    }
}
