// Задача 23. Напишите программу, которая:
// 1. Принимает на вход число (N) 
// 2. Выдает таблицу кубов чисел от 1 до  N.


void TableCube(int number)
{
    int i = 1;
    while (i <= number)
    {
        Console.WriteLine($"{i,3} -> {i * i * i,6}");
        i++;
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
TableCube(n);