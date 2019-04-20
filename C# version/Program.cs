using System;

namespace TrickyCalculator
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("\nWelcome to this Tricky Calculator!\nGive me two integers and an operator symbol and the rest is on me.\n\nOK, let's get started!\n\n");

            var c1 = new Calculations();
            c1.BasicCalculations();

            Console.WriteLine("\nOK, now let's do something more advanced. We'll do one more calculation and I'll do some magics with the results of these two calculations.");
            var c2 = new Calculations();
            c2.BasicCalculations();

            Console.WriteLine("\nPlease note that all your results will be rounded for the purpose of the tricks I promised you.\nNow I'll show you the greatest common divisor of these two results.");

            if (Calculations.GreatestCommonDivisor(Math.Round(c1.GetResult()), Math.Round(c2.GetResult())) == 0)
            {
                Console.WriteLine("Well, everything is zero, so there's nothing to show you (also keep in mind that dividing by zero is impossible).");
            } else {
                Console.WriteLine("Well, the greatest common divisor of " + Math.Round(c1.GetResult()) + " and " + Math.Round(c2.GetResult()) + " is " + Calculations.GreatestCommonDivisor(Math.Round(c1.GetResult()), Math.Round(c2.GetResult())) + ".\n");
            }
            Console.WriteLine("Now, I'll do some tricks with your second result " + Math.Round(c2.GetResult()) + ".");
            c2.PrimeNumber();
            c2.CorrespondingFibonacci();
            c2.IsFibonacci();

            Console.WriteLine("\n\nThat's all for now! If you liked me, subscribe to mathinsanity.com.");
        }
    }
}