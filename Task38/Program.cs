// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDouble(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next();
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double MinArrayNum(double[] arr)
{
    double mininal = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < mininal)
        {
            mininal = arr[i];
        }
    }
    return mininal;
}

double MaxArrayNum(double[] arr)
{
    double maximal = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maximal)
        {
            maximal = arr[i];
        }
    }
    return maximal;
}

double[] array = CreateArrayRndDouble(6);
PrintArray(array);
Console.WriteLine();
double min = MinArrayNum(array);
double max = MaxArrayNum(array);
double res = max - min;
Console.WriteLine($"{max} - {min} = {res}");