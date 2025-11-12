using System;

namespace Task_6
{
    internal class TryCatchFinally
    {
        // First program: Convert input to integer using try-catch-finally
        public void ConvertToInteger()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                // Try converting to integer
                int number = Convert.ToInt32(input);
                Console.WriteLine($"You entered number: {number}");
            }
            catch (FormatException)
            {
                // If user enters letters or invalid number
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                // Always executes
                Console.WriteLine("Program Executed");
            }
        }

        // Second program: Check password using throw
        public void CheckPassword()
        {
            try
            {
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                // Throw an exception if password is too short
                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception ex)
            {
                // Handle thrown exception
                Console.WriteLine(ex.Message);
            }
        }
    }
}
