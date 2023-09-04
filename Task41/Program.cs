// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountNumbersGreaterZero(int count)
{
    int countPositiveNumber = 0;
    int number = 0;
    for (int i = 1; i <= count; i++)
    {
        Console.Write($"Введите {i}-е число: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            countPositiveNumber++;
        }
    }
    return countPositiveNumber;
}


Console.Write("Введите количество чисел ");
int countNumber = Convert.ToInt32(Console.ReadLine());

int countNumbersGreaterZero = CountNumbersGreaterZero(countNumber);
Console.WriteLine($"Чисел больше нуля введено: {countNumbersGreaterZero}");