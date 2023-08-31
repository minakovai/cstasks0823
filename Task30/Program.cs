// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] mass)
{
    int i = 0;
    var random = new Random();
    while (i < mass.Length)
    {
        mass[i] = random.Next(2);
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