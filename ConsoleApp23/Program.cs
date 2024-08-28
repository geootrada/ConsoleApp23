using System;
using System.Data.Common;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];

            Random random = new Random();

            int summSecondString = 0;
            int multiplyFirstColumn = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[ i, j ] = random.Next( 1, 10);
                    Console.Write(array[i, j] + " ");
                }
            Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                summSecondString += array[1, i];
            }
            Console.WriteLine($"Сумма второй строки равна {summSecondString}");

            for (int j = 0; j < array.GetLength(0); j++)
            {
                multiplyFirstColumn *= array[j, 0];
            }
            Console.WriteLine($"Произведение первого столбца равно {multiplyFirstColumn}");
        }
    }
}
