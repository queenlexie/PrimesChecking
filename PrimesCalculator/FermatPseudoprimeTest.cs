using System;

namespace PrimesCalculator{
    public class FermatPseudoprimeTest : IPrimalityTest {
        private readonly int a; 

        public FermatPseudoprimeTest(int a){
            this.a = a;
        }

        public bool IsPrime(int n){
            // If it is composite and satisfy Fermat criterion  
            if (a > 1 && IsComposite(n) &&
                         ComputationUtils.Power(a, n - 1, n) == 1)
                return true;

            // Else return 0  
            return false;
        }       

        private static bool IsComposite(int n){
            // Check if there is any divisor of n  
            // less than sqrt(n)  
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return true;
            }
            return false;
        }
    }
}
