using System;

namespace Tak_1
{
    // Operators class containing all the required methods
    internal class Operators
    {
        // Add two numbers
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        // Subtract two numbers
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Difference: " + (a - b));
        }

        // Multiply two numbers
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Product: " + (a * b));
        }

        // Divide two numbers
        public void Divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine("Division: " + (a / b));
            else
                Console.WriteLine("Cannot divide by zero!");
        }

        // Determine if a number is odd or even using ternary operator
        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }
    }
}
