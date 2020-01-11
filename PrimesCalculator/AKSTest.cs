
namespace PrimesCalculator{
    public class AKSTest : IPrimalityTest {
        public bool IsPrime(int n) {
            // Calculating all the coefficients by 
            // the function coef and storing all 
            // the coefficients in c array . 
            long[] coeffs = computeCoefficients(n);

            // subtracting c[n] and adding c[0] by 1 
            // as ( x - 1 )^n - ( x^n - 1), here we 
            // are subtracting c[n] by 1 and adding 
            // 1 in expression. 
            coeffs[0]++;
            coeffs[n]--;

            // checking all the coefficients whether 
            // they are divisible by n or not. 
            // if n is not prime, then loop breaks 
            // and (i > 0). 
            int i = n;
            while ((i--) > 0 && coeffs[i] % n == 0);

            // Return true if all coefficients are 
            // divisible by n. 
            return i < 0;
        }

        // function to calculate the coefficients 
        // of (x - 1)^n - (x^n - 1) with the help 
        // of Pascal's triangle . 
        private static long[] computeCoefficients(int n){
            long[] coeffs = new long[100];

            coeffs[0] = 1;
            for (int i = 0; i < n; coeffs[0] = -coeffs[0], i++){
                coeffs[1 + i] = 1;
                for (int j = i; j > 0; j--)
                    coeffs[j] = coeffs[j - 1] - coeffs[j];
            }
            return coeffs;
        }
    }
}
