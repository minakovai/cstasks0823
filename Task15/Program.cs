// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool CheckHoliday(int digit)
{
    return digit > 5 && digit < 8;
}

bool CheckWeek(int dig)
{
    return dig > 0 && dig < 8;
}

Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
if (CheckWeek(day) == false) Console.WriteLine("Вы ввели не день недели");
else if (CheckHoliday(day) == true) Console.WriteLine("да");
else Console.WriteLine("нет");