using System;

namespace Tak_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of Operators class
            Operators op = new Operators();

            // Call all methods of Operators class
            op.Add(10, 5);          // Example: sum
            op.Subtract(10, 5);     // Example: difference
            op.Multiply(10, 5);     // Example: product
            op.Divide(10, 5);       // Example: division
            op.OddEvenFinder(10);   // Example: even check
            op.OddEvenFinder(7);    // Example: odd check
        }
    }
}
