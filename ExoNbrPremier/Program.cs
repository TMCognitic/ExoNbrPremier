using System;
using System.Collections.Generic;

namespace ExoNbrePremier
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int x, loopCount = 0;

            do
            {
                Console.Clear();
                Console.Write("Veuillez entrer un nombre > 0 : ");
            } while (!int.TryParse(Console.ReadLine(), out x) || x < 1);


            for (int count = 0, value = 2; count < x; value++)
            {
                bool isPrime = true;

                int square = (int)Math.Sqrt(value);
                for (int i = 2; i <= square && isPrime; i++, loopCount++)
                {
                    if (value % i == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"{value} is prime!");
                    count++;
                }            
            }
            Console.WriteLine($"Nombre de boucles : {loopCount}");
            Console.ReadLine();
            Console.WriteLine();

            List<int> primes = new List<int>();
            loopCount = 0;

            for (int count = 0, value = 2; count < x; value++)
            {
                bool isPrime = true;

                int square = (int)Math.Sqrt(value);
                for (int i = 0; square > 1 && primes[i] <= square && isPrime; i++, loopCount++)
                {
                    if (value % primes[i] == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    primes.Add(value);
                    Console.WriteLine($"{value} is prime!");
                    count++;
                }
            }
            Console.WriteLine($"Nombre de boucles : {loopCount}");
        }
    }
}
