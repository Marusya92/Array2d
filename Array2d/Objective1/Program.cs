// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            {7, 2, 4},
            {6, 5, 3},
            {1, 8, 9}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        Console.Write("Введите номер строки: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = Convert.ToInt32(Console.ReadLine());

        int? element = GetElementValue(array, row, col);

        if (element.HasValue)
        {
            Console.WriteLine($"Значение элемента на позиции [{row}, {col}]: {element}");
        }
        else
        {
            Console.WriteLine($"Элемента на позиции [{row}, {col}] не существует.");
        }
    }

    static int? GetElementValue(int[,] array, int row, int col)
    {
        int numRow = array.GetLength(0);
        int numCol = array.GetLength(1);

        if (row >= 0 && row < numRow && col >= 0 && col < numCol)
        {
            return array[row, col];
        }
        else
        {
            return null;
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

