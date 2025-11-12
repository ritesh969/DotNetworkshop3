using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TryCatchFinally obj = new TryCatchFinally();

            // First part - try catch finally demonstration
            obj.ConvertToInteger();

            Console.WriteLine(); // blank line for readability

            // Second part - password validation demonstration
            obj.CheckPassword();
        }
    }
}
