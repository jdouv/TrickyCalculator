using System;

namespace TrickyCalculator
{
    public class Calculations : NumbersAndOperators
    {
        // Initialize variable
        private decimal _result;

        // Basic calculations method with numbers refinement where necessary
        internal void BasicCalculations()
        {
            SetOperator();
            switch (NumberOperator)
            {
                case ("+"):
                    SetNumbers();
                    Console.WriteLine("The sum of these two numbers is " + Sum() + ".");
                    SetResult(Sum());
                    break;
                case ("-"):
                    SetNumbers();
                    Console.WriteLine("The result of this subtraction is " + Subtraction() + ".");
                    SetResult(Subtraction());
                    break;
                case ("*"):
                    SetNumbers();
                    Console.WriteLine("The result of this multiplication is " + Multiplication() + ".");
                    SetResult(Multiplication());
                    break;
                case ("/"):
                    SetNumbers();
                    DivisionCheckZero();
                    if (Division() % 1 == 0)
                    { // Remove decimals if result is integer
                        Console.WriteLine("The result of this division is {0:N2}.", Division());
                    } else {
                        Console.WriteLine("The result of this division is {0:N2}.", Division());
                    }
                    SetResult(Division());
                    break;
                case ("%"):
                    SetNumbers();
                    DivisionCheckZero();
                    Console.WriteLine("The result of this modular calculation is " + Mod() + ".");
                    SetResult(Mod());
                    break;
                case ("s"):
                    Console.WriteLine("Great! Now give me a number for this square root calculation:");
                    SetNumber();
                    while (Number < 0)
                    {
                        Console.WriteLine("You cannot calculate the square root of a negative number. Please try again:");
                        SetNumber();
                    }
                    if (Sqrt() % 1 == 0)
                    { // Remove decimals if result is integer
                        Console.WriteLine("The square root of {0:N0} is {1:N2}.", Number, Sqrt());
                    } else {
                        Console.WriteLine("The square root of {0:N0} is {1:N2}.", Number, Sqrt());
                    }
                    SetResult(Sqrt());
                    break;
                default:
                    Console.WriteLine("Oops! Something happened. Please restart me.");
                    break;
            }
        }

        // The "substantial" calculations methods for managing and refining numbers
        private long Sum()
        {
            return Number + Number2;
        }

        private long Subtraction()
        {
            return Number - Number2;
        }

        private long Multiplication()
        {
            return Number * Number2;
        }

        private decimal Division()
        {
            decimal x = Number; // Numbers converted to decimals if return is decimal
            decimal y = Number2;
            if (y == 0)
            { // "Emergency" result if input check fails (since there is no division with zero)
                return 0;
            }
            return x / y;
        }

        private long Mod()
        {
            if (Number2 == 0)
            { // "Emergency" result if input check fails (since there is no division with zero)
                return 0;
            }
            return Number % Number2;
        }

        private decimal Sqrt()
        {
            return (decimal) Math.Sqrt(Number);
        }

        private void SetResult(decimal result)
        {
            _result = result;
        }

        internal decimal GetResult()
        {
            return _result;
        }

        // Advanced methods
        internal static long GreatestCommonDivisor(decimal a, decimal b)
        {
            while (true)
            {
                if (b == 0) return (long) Math.Abs(a);
                var a1 = a;
                a = b;
                b = a1 % b;
            }
        }

        internal void PrimeNumber()
        {
            if (Math.Abs(Math.Round(_result)) == 0 || Math.Abs(Math.Round(_result)) == 1)
            {
                Console.WriteLine(Math.Abs(Math.Round(_result)) + " is not a prime number.");
            } else {
                var prime = true;
                for (long i=2;i<=Math.Abs(Math.Round(_result))/2;i++)
                {
                    var tmp = Math.Abs(Math.Round(_result)) % i;
                    if (tmp != 0) continue;
                    prime = false;
                    break;
                }
                if (prime)
                {
                    Console.WriteLine("Well, " + Math.Abs(Math.Round(_result)) + " is a prime number.");
                } else {
                    Console.WriteLine("Well, " + Math.Abs(Math.Round(_result)) + " is not a prime number.");
                }
            }
        }

        internal void CorrespondingFibonacci()
        {
            long a = 0;
            long b = 1;
            long result = 0;

            if (Math.Abs(Math.Round(_result)) == 0 || Math.Abs(Math.Round(_result)) == 1)
            {
                Console.WriteLine("The corresponding Fibonacci number of " + Math.Abs(Math.Round(_result)) + " is " + Math.Abs(Math.Round(_result)) + " itself.");
            } else {
                for (long i=2;i<=Math.Abs(Math.Round(_result));i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }
                Console.WriteLine("The corresponding Fibonacci number of " + Math.Abs(Math.Round(_result)) + " is " + result + ".");
            }
        }

        internal void IsFibonacci()
        {
            long a = 0;
            long b = 1;
            long result = 0;

            while (result < Math.Abs(Math.Round(_result)))
            {
                result = a + b;
                a = b;
                b = result;
            }

            if (result == Math.Abs(Math.Round(_result)))
            {
                Console.WriteLine(Math.Abs(Math.Round(_result)) + " is a Fibonacci number.");
            } else {
                Console.WriteLine(Math.Abs(Math.Round(_result)) + " is not a Fibonacci number.");
            }
        }
    }
}