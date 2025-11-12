using System;

namespace Task_3
{
    internal class IfElseSwitch
    {
        public void CheckAgeCategory()
        {
            Console.Write("Enter your age: ");
            int age;

            // Validate user input
            bool isValid = int.TryParse(Console.ReadLine(), out age);
            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number for age.");
                return;
            }

            // Using if-else-if structure
            if (age < 13)
            {
                Console.WriteLine("You are a Child.");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a Teenager.");
            }
            else
            {
                Console.WriteLine("You are an Adult.");
            }

            // Using switch for demonstration
            switch (age)
            {
                case < 13:
                    Console.WriteLine("(Switch) You are a Child.");
                    break;

                case >= 13 and <= 19:
                    Console.WriteLine("(Switch) You are a Teenager.");
                    break;

                default:
                    Console.WriteLine("(Switch) You are an Adult.");
                    break;
            }
        }
    }
}
