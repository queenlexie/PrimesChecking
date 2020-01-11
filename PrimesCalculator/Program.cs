using System;
using System.Collections.Generic;

namespace PrimesCalculator {
    public class Program {
        private readonly IPrimalityTest fermatTest;
        private readonly IPrimalityTest millerRabinTest;
        private readonly IPrimalityTest aksTest;
        private readonly IPrimalityTest fermatPseudoprimeTest;
        private readonly ISet<int> alreadyCheckedNumbers;

        public Program(){
            fermatTest = new FermatTest(10);
            millerRabinTest = new MillerRabinTest(10);
            aksTest = new AKSTest();
            fermatPseudoprimeTest = new FermatPseudoprimeTest(2);
            alreadyCheckedNumbers = new HashSet<int>();
        }
        

        public static void Main(string[] args){
            new Program().doRun();
        }

        private void doRun(){
            Console.WriteLine("Hello! Choose one of the following:");
            Console.WriteLine("- provide the number (integer) you would like to check whether is prime or not,");
            Console.WriteLine("- type 'print-processed' to see the list of all checked primes,");
            Console.WriteLine("- type 'exit' to exit program.");
            String input = Console.ReadLine();
            bool continueExec = true;
            switch (input){
                case "exit":
                    continueExec = false;
                    break;
                case "print-processed":
                    Console.WriteLine("Already processed numbers:");
                    Console.WriteLine($"({String.Join(", ", alreadyCheckedNumbers)})");
                    break;
                default:
                    try
                    {
                        int number = Convert.ToInt32(input);
                        doRunPrimeTest(number);
                    } catch (Exception){
                        Console.WriteLine($"Invalid input parsed: {input}");
                    }
                    break;
            }
            if (continueExec)
                doRun();
        }

        private void doRunPrimeTest(int number){
            Counter counter = new Counter();
            PerformFermatTest(number, counter);
            PerformMillerRabinTest(number, counter);
            PerformAksTest(number, counter);
            PerformFermatPseudoprimeTest(number, counter);

            Console.WriteLine(MakeTestResultMessage(counter.GetCounter()));
            alreadyCheckedNumbers.Add(number);
        }

        private void PerformFermatTest(int number, Counter counter){
            if (fermatTest.IsPrime(number)){
                counter.Increment();
                Console.WriteLine("Result of Fermat Test is true, it means that you may have chosen a prime number");
            }
            else
                Console.WriteLine("Result of Fermat Test is false, it means that you may have chosen a composite number");
        }

        private void PerformMillerRabinTest(int number, Counter counter){
            if (millerRabinTest.IsPrime(number)){
                counter.Increment();
                Console.WriteLine("Result of Miller-Rabin Test is true, it means that you may have chosen a prime number");
            }
            else
                Console.WriteLine("Result of Miller-Rabin Test is false, it means that you may have chosen a composite number");
        }

        private void PerformFermatPseudoprimeTest(int number, Counter counter){
            if (fermatPseudoprimeTest.IsPrime(number)){
                Console.WriteLine("Unfortunately, you chose a pseudoprime");
                counter.Decrement();
            }
        }

        private void PerformAksTest(int number, Counter counter){
            if (number < 100){
                if (aksTest.IsPrime(number)){
                    counter.Increment();
                    Console.WriteLine("Result of AKS Test is true, it means that you may have chosen a prime number");
                }
                else
                    Console.WriteLine("Result of AKS Test is false, it means that you may have chosen a composite number");
            }
            else
                Console.WriteLine(" Your number is too big to provide AKS Test, so it will be skipped");
        }

        private String MakeTestResultMessage(int counter){
            return counter switch {
                0 => "Your number is definitely a composite number",
                1 => "Your number is composite",
                2 => "Your number may be a prime number",
                3 => "Your number is definitely a prime number",
                _ => "Your number probably is a pseudoprime",
            };
        }
    }
}
