using System;

namespace TrickyCalculator
{
    public class NumbersAndOperators
    {
        //Initialize variables
        protected long Number, Number2;
        protected string NumberOperator;

        // Method to set operators
        protected void SetOperator()
        {
            Console.WriteLine("First, tell me the type of calculation you want based on the following symbols:\n+ for addition,\n- for subtraction,\n* for multiplication,\n/ for division,\n% for modular calculation and\ns to calculate the square root.");
            NumberOperator = Console.ReadLine();
            while(NumberOperator != null && !(NumberOperator.Equals("+") || NumberOperator.Equals("-") ||
                                              NumberOperator.Equals("*") || NumberOperator.Equals("/") ||
                                              NumberOperator.Equals("%") || NumberOperator.Equals("s")))
            {
                Console.WriteLine("Oops! Give me a valid operator:");
                NumberOperator = Console.ReadLine();
            }
        }

        // Numbers management methods
        protected void SetNumber()
        {
            var temp = Console.ReadLine();
            Number = Convert.ToInt32(temp);
            while (!long.TryParse(temp, out Number))
            {
                Console.WriteLine("Please input a valid integer:");
                temp = Console.ReadLine();
                Number = Convert.ToInt32(temp);
            }
        }

        private void SetNumber2()
        {
            var temp = Console.ReadLine();
            Number2 = Convert.ToInt32(temp);
            while (!long.TryParse(temp, out Number2))
            {
                Console.WriteLine("Please input a valid integer:");
                temp = Console.ReadLine();
                Number2 = Convert.ToInt32(temp);
            }
        }

        protected void SetNumbers()
        {
            Console.WriteLine("OK, now give me the first number:");
            SetNumber();
            Console.WriteLine("And the second number:");
            SetNumber2();
        }

        protected void DivisionCheckZero()
        {
            while (Number2 == 0)
            {
                Console.WriteLine("You cannot divide by zero. Please try again:");
                SetNumber2();
            }
        }
    }
}