// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int num1, int num2)
{
    int res = 1;
    for (int i = 1; i <= num2; i++)
    {
        res = res * num1;
        Console.WriteLine($"{i} -> {res}");
    }
    return res;
}

Console.Write("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числов B: ");
int power = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} ^ {power} = {Exponentiation(number, power)}");
