using System;
using System.Data.Common;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[ 6, 5 ];

            Random random = new Random();

            int sumSpecifiedString = 0;
            int multiplySpecifiedColumn = 1;
            int indexString = 1;
            int indexColumn = 0;
            int indexOffset = 1;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(1, 10);
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                sumSpecifiedString += numbers[ indexString, j];
            }

            Console.WriteLine($"Сумма строки {indexString + indexOffset} равна {sumSpecifiedString}");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                multiplySpecifiedColumn *= numbers[i, indexColumn];
            }

            Console.WriteLine($"Произведение столбца {indexColumn + indexOffset} равно {multiplySpecifiedColumn}");
        }
    }
}
