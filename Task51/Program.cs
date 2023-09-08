﻿// // Задача 51: Задайте двумерный массив. Найдите сумму
// // элементов, находящихся на главной диагонали (с индексами
// // (0,0); (1;1) и т.д.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int SumBothCommonIndexes(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int size = rows < columns ? rows : columns;
    int sum = 0;

    for(int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}
void PrintArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintArray(matrix);
Console.WriteLine();
int sumElements = SumBothCommonIndexes(matrix);
Console.WriteLine(sumElements);






// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix (int[,] matrix)
// {
    
//     for (int i=0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j],5}");
//         }
//         Console.WriteLine();
//     }
// }

// void SumBothIndexes (int[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);
//     int size = rows < columns ? rows : columns;
//     int sum = 0;
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             sum += matrix[i,i];
//         }
//     }
// }

// int[,] array2d = CreateMatrixRndInt(5,5,0,10);
// PrintMatrix(array2d);
// int sumElements = SumBothIndexes(array2d);
// EvenIndicesInPow(array2d);
// Console.WriteLine();
// PrintMatrix(array2d);