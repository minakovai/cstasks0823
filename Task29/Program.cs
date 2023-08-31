// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void FillArray(int[] mass)
{
    int i = 0;
    var random = new Random();
    while (i < mass.Length)
    {
        mass[i] = random.Next(100);
        i++;
    }
}

void PrintArray(int[] mass)
{
    int i = 0;
    while (i < mass.Length)
    {
        Console.Write($"{mass[i]} ");
        i++; 
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);