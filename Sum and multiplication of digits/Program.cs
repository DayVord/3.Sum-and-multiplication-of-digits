using System;

namespace Sum_and_multiplication_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to use? : ");
            int numbersAmount = int.Parse(Console.ReadLine());

            int[] numbers = new int[numbersAmount];

            for (int i = 0; i < numbersAmount; i++)
            {
                Console.WriteLine();
                Console.Write($"Enter the {i+1}st number:\t");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < numbersAmount; i++)
            {
                sum += numbers[i];
            }

            int product = 1;
            for (int i = 0; i < numbersAmount; i++)
            {
                product *= numbers[i];
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Console.WindowWidth/2}The sum of numbers is {sum}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The product of numbers is {product}");

            Console.ReadKey();
        }
    }
}
