using System;
using System.Data.Common;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[3, 3];

            Random random = new Random();

            int summSecondString = 0;
            int multiplyFirstColumn = 1;
            int numberString = 1;
            int numberColumn = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(1, 10);
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                summSecondString += numbers[numberString, i];
            }

            Console.WriteLine($"Сумма второй строки равна {summSecondString}");

            for (int j = 0; j < numbers.GetLength(0); j++)
            {
                multiplyFirstColumn *= numbers[j, numberColumn];
            }

            Console.WriteLine($"Произведение первого столбца равно {multiplyFirstColumn}");
        }
    }
}
