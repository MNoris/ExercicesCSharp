using System;

namespace PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q;

            Console.WriteLine("Entrez le premier nombre : ");
            q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le deuxième nombre : ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Le PGCD de {q} et {p} est : {PGCD(p, q)}");
        }

        static int PGCD(int p, int q)
        {
            while (p != q)
            {
                if (p > q)
                {
                    p = p - q;
                }
                else if (p <= q)
                {
                    q = q - p;
                }
            }

            return p;
        }
    }
}
