using System;
using System.Collections.Generic;

namespace Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Primes = new List<int>() { 2 };
            

            Console.WriteLine("Insert a number to be the limit of your Sieve of Erastothenes: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 3; i <= number; i++)
            {
                for (int j = i - 1; j >= 2; j--)
                {
                    if (j == 2 && i % 2 != 0)
                    {
                        Primes.Add(i);
                    }
                    else if (i % j == 0)
                    {
                        j = 1;
                    }
                    else
                    {
                        j = j;
                    }
                }
            }

            Console.WriteLine("Your Sieve of Erastothenes is: ");

            foreach (int prime in Primes)
            {
                Console.WriteLine(prime);

            }

            Console.ReadKey();

        }
    }
}