// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();
void NaturalNumbers(int number1, int number2)
{
    if (number1 < 1 || number2 < 1)
    {
        System.Console.WriteLine("Некорректный ввод!");
        return;
    }
}



void RangeNaturalNumbers(int a, int b)
{
    if (a < b)
    {
        Console.Write($"{a} ");
        RangeNaturalNumbers(a + 1, b);
    }
    else if (a > b)
    {
        Console.Write($"{a} ");
        RangeNaturalNumbers(a - 1, b);
    }
    else
    {
        Console.Write($"{a}");
    }

}

Console.WriteLine("Введите натуральное число M");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number1, number2);
RangeNaturalNumbers(number1, number2);