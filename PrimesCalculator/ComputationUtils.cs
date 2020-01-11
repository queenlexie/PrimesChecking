
namespace PrimesCalculator{
    class ComputationUtils{
        private ComputationUtils(){}
        public static int Power(int expBase, int power, int p){
            int res = 1;

            expBase %= p;
            while (power > 0){
                // If y is odd, multiply x with result 
                if ((power & 1) == 1)
                    res = (res * expBase) % p;

                // y must be even now 
                power >>= 1; // y = y/2 
                expBase = (expBase * expBase) % p;
            }
            return res;
        }
    }
}
