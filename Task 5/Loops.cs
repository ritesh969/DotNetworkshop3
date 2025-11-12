using System;

namespace Task_5
{
    internal class Loops
    {
        // 1️⃣ For loop: Sum from 1 to N
        public void SumUsingForLoop()
        {
            Console.Write("Enter a number N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum from 1 to {N} is: {sum}");
        }

        // 2️⃣ While loop: Print 1 to 20, skip multiples of 4, stop at 15
        public void PrintUsingWhileLoop()
        {
            int num = 1;
            Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");

            while (num <= 20)
            {
                if (num % 4 == 0)
                {
                    num++;
                    continue; // Skip multiples of 4
                }

                if (num == 15)
                {
                    Console.WriteLine("Stopping at 15 (break).");
                    break; // Stop when number is 15
                }

                Console.WriteLine(num);
                num++;
            }
        }

        // 3️⃣ Foreach loop: Sum of all elements in an array
        public void SumUsingForEachLoop()
        {
            int[] numbers = new int[5];
            Console.WriteLine("\nEnter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            foreach (int n in numbers)
            {
                total += n;
            }

            Console.WriteLine($"The sum of all elements in the array is: {total}");
        }
    }
}
