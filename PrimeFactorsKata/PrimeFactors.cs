using System;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public class PrimeFactors
    {
        public static List<int> Generate(int number)
        {
            if (number <= 0)
                return new List<int>();

            if (number == 1)
                return new List<int> { 1 };

            List<int> primeFactors = new List<int>();

            for (var i = 2; i <= number; i++)
            {
                while (IsPrime(i) && number % i == 0)
                {
                    primeFactors.Add(i);
                    number /= i;
                }
            }

            return primeFactors;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            if (number == 2 || number == 3)
                return true;

            for (var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                    return false;
            }

            return true;
        }
    }
}