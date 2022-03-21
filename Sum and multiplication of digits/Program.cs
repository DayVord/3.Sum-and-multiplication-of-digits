using System;

namespace Sum_and_multiplication_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to use?");
            int numbersAmount = 0;

            for (int x = 0; ; x++)
            {
                if (Int32.TryParse(Console.ReadLine(), out numbersAmount))
                {
                    int[] numbers = new int[numbersAmount];

                    for (int i = 0; i < numbersAmount; i++)
                    {
                        for (int y = 0; ; y++)
                        {
                            if (Int32.TryParse(Console.ReadLine(), out numbers[i]))
                            {
                                Console.WriteLine();
                                Console.Write($"Enter the {i + 1}st number:\t");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("You had to enter a numeric value");
                                Console.WriteLine();
                                Console.ResetColor();
                            }
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
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("You had to enter a numeric value");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
            Console.ReadKey();
        }
    }
}
