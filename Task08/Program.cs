﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());
int i=2;

while (i<number)
{
    if (i%2==0)
    {
        Console.Write($"{i}, "); // Тут хитрого решения, чтобы поставить точку на последнем элементе пока не придумал
    }
i=i+2;      
}
if (i==number)
{
    Console.WriteLine($"{i}."); // Если последнее число четное, то поставим в конце точку.
}
