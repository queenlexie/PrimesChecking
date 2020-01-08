using System;
using System.Collections.Generic;
using System.Text;

namespace PrimesCalculator
{
    public class FermatTest
    {
        // Perform tests to see if a number is (probably) prime.
        private static Random Rand = new Random();

        public static Random Rand1 { get => Rand; set => Rand = value; }

        public static bool IsProbablyPrime(int p, int num_tests)
        {
            checked
            {
                // Perform the tests.
                for (int i = 0; i < num_tests; i++)
                {
                    // Pick a number n in the range (1, p).
                    long n = Rand1.Next(2, p);

                    // Calculate n ^ (p - 1).
                    long result = n;
                    for (int power = 1; power < p - 1; power++)
                    {
                        result = (result * n) % p;
                    }

                    // If the final result is not 1, p is not prime.
                    if (result != 1) return false;
                }
            }

            // If we survived all the tests, p is probably prime.
            return true;
        }
    }
}
