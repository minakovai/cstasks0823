﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"


Console.Clear();
Console.WriteLine("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    System.Console.WriteLine("Некорректный ввод!");
    return;
}

Console.Write($"N = {number} -> ");
NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}