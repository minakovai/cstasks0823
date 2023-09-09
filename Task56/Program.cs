// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] SumNumbersInRow(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arr[i] = sum;
        sum = 0;
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
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

void SearchRowSmallestAmount(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    
    Console.WriteLine($"Строка с наименьшей суммой элементов - номер: {index}. Нумерация строк с нуля!");

}

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 5);
PrintMatrix(matrix);
int[] array = SumNumbersInRow(matrix);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
SearchRowSmallestAmount(array);