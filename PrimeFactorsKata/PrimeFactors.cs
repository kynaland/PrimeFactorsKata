using System;
using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public class PrimeFactors
    {
        public static List<int> Generate(int n)
        {
            if (n <= 0)
                return new List<int>();

            if (n == 1)
                return new List<int> { 1 };

            List<int> primeFactors = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i) && n % i == 0)
                    primeFactors.Add(i);
            }

            return primeFactors;
        }

        public static bool IsPrime(int i)
        {
            if (i < 2)
                return false;

            if (i == 2 || i == 3)
                return true;

            for (int div = 2; div <= Math.Sqrt(i); div++)
            {
                if (i % div == 0)
                    return false;
            }

            return true;
        }
    }
}