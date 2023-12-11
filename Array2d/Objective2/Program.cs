// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            {8, 2, 1},
            {9, 3, 4},
            {7, 5, 6}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        SwapFirstAndLastRows(array);

        Console.WriteLine("Массив после обмена строк:");
        PrintArray(array);
    }

    static void SwapFirstAndLastRows(int[,] array)
    {
        int numRow = array.GetLength(0);
        int numCol = array.GetLength(1);

        if (numRow > 1)
        {
            int[] tempRow = new int[numCol];
            for (int j = 0; j < numCol; j++)
            {
                tempRow[j] = array[0, j];
            }

            for (int j = 0; j < numCol; j++)
            {
                array[0, j] = array[numRow - 1, j];
            }

            for (int j = 0; j < numCol; j++)
            {
                array[numRow - 1, j] = tempRow[j];
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        int numRow = array.GetLength(0);
        int numCol = array.GetLength(1);

        for (int i = 0; i < numRow; i++)
        {
            for (int j = 0; j < numCol; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}