using System;

namespace PrimesCalculator
{
    class Program
    {
        static void Main(string[] args)
        { /*
            //FermatTest
            Console.WriteLine(FermatTest.IsProbablyPrime(37, 10));

            //Fermat Pseudoprimes

            Console.WriteLine(FermatPseudoprimeTest.Check(645, 2));

            //MR Test
            int k = 4; // Number of iterations 

            Console.WriteLine("All primes smaller " +
                                       "than 100: ");

            for (int n = 1; n < 100; n++)
                if (MillerRabinTest.isPrime(n, k))
                    Console.Write(n + " ");

            //AKS Test
            if (AKSTest.isPrime(37))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");
                */
            int counter = 0;
            Console.WriteLine("Hello! Provide the number you would like to check whether is prime or not");
            int number=Convert.ToInt32(Console.ReadLine());
            if(FermatTest.IsProbablyPrime(number, 10) == true)
            {
                counter++;
                Console.WriteLine("Result of Fermat Test is true, it means that you may have chosen a prime number");
              
            }
            else
                Console.WriteLine("Result of Fermat Test is false, it means that you may have chosen a composite number");
            if (MillerRabinTest.isPrime(number, 10) == true)
            {
                counter++;
                Console.WriteLine("Result of Miller-Rabin Test is true, it means that you may have chosen a prime number");
            }
            else
                Console.WriteLine("Result of Miller-Rabin Test is false, it means that you may have chosen a composite number");
            if (number < 100)
            {
                if (AKSTest.isPrime(number) == true)
                {
                    counter++;
                    Console.WriteLine("Result of AKS Test is true, it means that you may have chosen a prime number");
                }
                else
                    Console.WriteLine("Result of AKS Test is false, it means that you may have chosen a composite number");
            }
            else
                Console.WriteLine(" Your number is too big to provide AKS Test, so it will be skipped");
            if (FermatPseudoprimeTest.Check(number, 2) == true)
            {
                Console.WriteLine("Unfortunately, you chose a pseudoprime");
                counter = -1;
            }

            switch (counter)
            {
                case 0:
                    Console.WriteLine("Your number is definitely a composite number");
                    break;
                case 1:
                    Console.WriteLine("Your number is composite");
                    break;
                case 2:
                    Console.WriteLine("Your number may be a prime number");
                    break;
                case 3:
                    Console.WriteLine("Your number is definitely a prime number");
                    break;
                default:
                    Console.WriteLine("Your number probably is a pseudoprime");
                    break;
            }

            }
    }
}
