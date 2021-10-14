using System;

namespace FindFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using recursion to calculate the factorial of a number.
            Console.WriteLine("Enter a number to calculate the factorial of: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The factorial of {0} is {1}", number, Factorial(number));
            Console.ReadLine();
        }

        static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
