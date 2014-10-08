using System;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    //> Write a class named “PrimeFactors” that has one static method: generate.
    //> The generate method takes an integer argument and returns a List<Integer>.
    //> That list contains the prime factors in numerical sequence.

    class Program
    {
        static void Main(string[] args)
        {
            const int n = -1;

            var primeFactors = PrimeFactors.Generate(n);

            ConsoleOutput(primeFactors);

            Console.ReadLine();
        }

        //test
        private static void ConsoleOutput(IEnumerable<int> list)
        {
            foreach (var element in list)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }
    }
}
