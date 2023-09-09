// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;

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

bool CheckingComplianceStrokeColumns(int[,] matrixA, int[,] matrixB)
{
    int columnsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    if (columnsA == rowsB)
    {
        Console.WriteLine("Матрицы перемножать можно. Число столбцов первой равно числу строк второй!");
        return true;
    }

    else return false;
}


int[,] matrixA = CreateMatrixRndInt(2, 2, 0, 15);
int[,] matrixB = CreateMatrixRndInt(2, 2, 0, 15);
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
// int[] array = SumNumbersInRow(matrix);
// Console.WriteLine();
// PrintArray(array);
if (CheckingComplianceStrokeColumns(matrixA, matrixB) == true)
{
    int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
    PrintMatrix(matrixC);
}
else  Console.WriteLine("Матрицы перемножать нельзя! Число столбцов первой не соответствует числу строк второй!");
