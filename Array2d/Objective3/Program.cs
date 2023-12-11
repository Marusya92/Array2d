// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();


        int numRow = 3;
        int numCol = 3;

        int[,] array = GenerateRandomArray(numRow, numCol, random);

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int minSumRow = FindRowWithMinSum(array);

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");

        static int[,] GenerateRandomArray(int numRows, int numColumns, Random random)
        {
            int[,] array = new int[numRows, numColumns];

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    array[i, j] = random.Next(1, 10);
                }
            }

            return array;
        }

        static int FindRowWithMinSum(int[,] array)
        {
            int numRows = array.GetLength(0);
            int numColumns = array.GetLength(1);

            if (numRows == 0 || numColumns == 0)
            {
                throw new ArgumentException("Массив не должен быть пустым.");
            }

            int minSum = int.MaxValue;
            int minSumRow = -1;

            for (int i = 0; i < numRows; i++)
            {
                int currentSum = 0;

                for (int j = 0; j < numColumns; j++)
                {
                    currentSum += array[i, j];
                }

                if (currentSum < minSum)
                {
                    minSum = currentSum;
                    minSumRow = i;
                }
            }

            return minSumRow;
        }

        static void PrintArray(int[,] array)
        {
            int numRows = array.GetLength(0);
            int numColumns = array.GetLength(1);

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}