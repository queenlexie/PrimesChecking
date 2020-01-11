using System;

namespace PrimesCalculator{
    public class MillerRabinTest : IPrimalityTest{
        private readonly Random rng;
        private readonly int k;

        public MillerRabinTest(int accuracyLevel){
            this.rng = new Random();
            this.k = accuracyLevel;
        }

        // It returns false if n is composite  
        // and returns true if n is probably  
        // prime. k is an input parameter that  
        // determines accuracy level. Higher  
        // value of k indicates more accuracy.
        public bool IsPrime(int n){
            // Corner cases 
            if (n <= 1 || n == 4)
                return false;
            if (n <= 3)
                return true;

            // Find r such that n = 2^d * r + 1  
            // for some r >= 1 
            int d = n - 1;

            while (d % 2 == 0)
                d /= 2;

            // Iterate given nber of 'k' times 
            for (int i = 0; i < k; i++)
                if (!MillerTest(d, n))
                    return false;

            return true;
        } 

        // This function is called for all k trials.  
        // It returns false if n is composite and  
        // returns false if n is probably prime. 
        // d is an odd number such that d*2<sup>r</sup> 
        // = n-1 for some r >= 1 
        private bool MillerTest(int d, int n){
            // Pick a random number in [2..n-2] 
            // Corner cases make sure that n > 4 
            int a = 2 + (int)(rng.Next() % (n - 4));

            // Compute a^d % n 
            int x = ComputationUtils.Power(a, d, n);

            if (x == 1 || x == n - 1)
                return true;

            // Keep squaring x while one of the 
            // following doesn't happen 
            // (i) d does not reach n-1 
            // (ii) (x^2) % n is not 1 
            // (iii) (x^2) % n is not n-1 
            while (d != n - 1){
                x = (x * x) % n;
                d *= 2;

                if (x == 1)
                    return false;
                if (x == n - 1)
                    return true;
            }
            return false;
        }
    }
}
