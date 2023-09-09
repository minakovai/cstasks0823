﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void RowsDescending(int[,] arr)
{
    int min = 0;
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            for (int z = 0; z < arr.GetLength(1) - j - 1; z++)
            {
                if (arr[i, z] < arr[i, z + 1])
                {
                    temp = arr[i, z];
                    arr[i, z] = arr[i, z + 1];
                    arr[i, z + 1] = temp;
                }
            }
        }
    }
    return;
}


void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(matrix);
RowsDescending(matrix);
Console.WriteLine();
PrintMatrix(matrix);