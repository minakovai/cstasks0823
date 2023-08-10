// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

bool CheckThreeDigits(int threedig)
{
    return threedig > 99 && threedig < 1000;
}

int ThirdDigit(int num)
{
    int thrdig = num % 10;
    return thrdig;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
    {
        Console.WriteLine("В веденном числе нет третьей цифры");
    }

else 
{ 
    while (CheckThreeDigits (number) == false)
    {
        number = number / 10;
    }
    Console.WriteLine(ThirdDigit(number));
}




