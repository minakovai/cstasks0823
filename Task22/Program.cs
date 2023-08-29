// Задача 22: Написать программу, которая:
// 1. Принимает на вход число (N)
// 2. Выдает таблицу квадратов от 1 до N
// Пример: 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

void TableSquare(int number)
{
    int i = 1;
    while (i <= number)
    {
        Console.WriteLine($"{i,3} -> {i * i,5}");
        i++;
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
TableSquare(n);