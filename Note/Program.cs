using System;
using System.IO;

namespace Note
{
    class Program
    {
        static void Main(string[] args)
        {
            SaisirNote();
        }

        static void SaisirNote()
        {
            string path, text;

            Console.WriteLine("Saisissez un texte, puis un chemin de fichier");
            path = Console.ReadLine();
            text = Console.ReadLine();

            //if (!Directory.Exists(path))
            //{
            //    throw new Exception("");
            //}

            try
            {
                EnregistrerNote(path, text);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public void EnregistrerNote(string path, string text)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(text);
            }

            //StreamWriter sw = null;

            //try
            //{
            //    sw = new StreamWriter(path, true);
            //    sw.WriteLine(text);
            //}
            //catch (DirectoryNotFoundException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if(sw != null) sw.Close();
            //}

        }
    }
}
