﻿// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool MultyplicityTwoNumbers(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}

Console.WriteLine ("Веедите число");
int number = Convert.ToInt32(Console.ReadLine());



bool result = MultyplicityTwoNumbers (number, 7,23);

Console.WriteLine(result? "Кратно" : "Не кратно");




// bool MultiplicityTwoNumbers(int num, int num1, int num2)
// {
//     return num % num1 == 0 && num % num2 == 0;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool result = MultiplicityTwoNumbers(number, 3, 11);

// Console.WriteLine(result? "Кратно" : "Не кратно");
