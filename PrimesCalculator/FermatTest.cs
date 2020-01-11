using System;
using System.Collections.Generic;

namespace PrimesCalculator {
    public class FermatTest : IPrimalityTest {
        private readonly Random randomNumberGenerator;
        private readonly int noOfTests;
        private readonly Dictionary<int, bool> cache;

        public FermatTest(int noOfTests){
            this.randomNumberGenerator = new Random();
            this.noOfTests = noOfTests;
            this.cache = new Dictionary<int, bool>();
        }

        public bool IsPrime(int p) {
            if (cache.ContainsKey(p)) {
                return cache[p];
            }
            else checked {
                // Perform the tests.
                for (int i = 0; i < noOfTests; i++) {
                    // Pick a number n in the range (1, p).
                    long n = randomNumberGenerator.Next(2, p);
                    // Calculate n ^ (p - 1).
                    long result = n;
                    for (int power = 1; power < p - 1; power++)
                        result = (result * n) % p;
                    // If the final result is not 1, p is not prime.
                    if (result != 1){
                        cache.Add(p, false);
                        return false;
                    }    
                }
            }
            // If we survived all the tests, p is probably prime.
            cache.Add(p, true);
            return true;
        }
    }
}
