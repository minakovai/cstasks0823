
bool CheckFiveDigits(int num1)
{
    if ((num1 > 9999) & (num1 < 100000)) return true;
    else return false;
}

void CheckPolindrom(int num)
{
    if (num / 10000 == num % 10)
    {
        if (((num / 1000) % 10) == ((num / 10) % 10))
            Console.WriteLine($"{num} -> да");
        else Console.WriteLine($"{num} -> нет");
    }
    else Console.WriteLine($"{num} -> нет");
}


Console.Write("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (CheckFiveDigits(number) == false) Console.WriteLine("Вы ввели не пятизначное число");
else CheckPolindrom(number);