using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez votre année de naissance\n");
            int anneeNaissance;
            int.TryParse(Console.ReadLine(), out anneeNaissance);

            int age = 2025 - anneeNaissance;

            if (age < 18)
                Console.WriteLine("Vous êtes mineur");
            else
                Console.WriteLine("Vous êtes majeur");
        }
    }
}