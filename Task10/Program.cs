// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

bool CheckThreeDigits(int threedig)
{
    return threedig > 99 && threedig < 1000;
}


int SecondDigit(int num)
{
    int secdig = (num / 10) % 10;
    return secdig;
}

Console.WriteLine("Введите  трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (CheckThreeDigits(number) == true)
{
    Console.WriteLine(SecondDigit(number));
}
else Console.WriteLine("Вы ввели не трехзначное число");