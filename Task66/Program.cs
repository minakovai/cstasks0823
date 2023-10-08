// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдет сумму всех натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> "120"
// M = 4; N = 8 -> "30"


Console.Clear();
void NaturalNumbers(int number1, int number2)
{
    if (number1 < 1 || number2 < 1)
    {
        System.Console.WriteLine("Некорректный ввод!");
    }
}


int SumRangeNaturalNumbers(int a, int b) // 4,6; 
{
    int result = a; // 4
    if (a == b) return a;
    if (a < b) // 4,6; 
    {
        return result + SumRangeNaturalNumbers(a + 1, b); //4 + 5 + 6
    }
    else
    {
        return SumRangeNaturalNumbers(b, a);
    }
}

Console.Write("Введите натуральное число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number1, number2);
int sum = SumRangeNaturalNumbers(number1, number2);
Console.WriteLine($"Сумма равна {sum}");