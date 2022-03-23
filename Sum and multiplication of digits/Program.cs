using System;

namespace Sum_and_multiplication_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to use?");
            int numbersAmount = 0;
            bool calculateNext = false;

            while (!calculateNext)
            {
                try
                {
                    numbersAmount = Convert.ToInt32(Console.ReadLine());
                    calculateNext = true;
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("You had to enter a numeric value");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }

            int[] numbers = new int[numbersAmount];

            for (int x = 0; x < numbersAmount; x++)
            {
                Console.WriteLine();
                Console.Write($"Enter the {x + 1}st number:\t");
            reEnter:
                try
                {

                    numbers[x] = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("You had to enter a numeric value");
                    Console.WriteLine();
                    Console.ResetColor();
                    goto reEnter;
                }

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

            Console.WriteLine($"The sum of numbers is {sum}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The product of numbers is {product}");

            Console.ReadKey();
        }
    }
}
