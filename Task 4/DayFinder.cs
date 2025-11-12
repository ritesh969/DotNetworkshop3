using System;

namespace Task_4
{
    internal class DayFinder
    {
        public void ShowDayOfWeek()
        {
            Console.Write("Enter a number (1–7): ");
            int dayNumber;

            // Validate input
            bool isValid = int.TryParse(Console.ReadLine(), out dayNumber);
            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number between 1 and 7.");
                return;
            }

            // Using switch to print day of the week
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter a number from 1 to 7.");
                    break;
            }
        }
    }
}
