// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Validation(int num)
{
    while (num < 1)
    {
        num = Prompt("Неверно введено число. Повторите ввод: ");
    }
    return num;
}

int Exponetial(int num1, int num2) //3, 5; 3,4; 3,2; 3,1; 3,0;
{
    if (num2 == 0) return 1; //1
    return num1 * Exponetial(num1, num2 - 1); //Это стек 3,5; 3,4; 3,3; 3,2; 3,1;
    //  3*3*3*3*3*1 (из return) = 243
}



int numberOne = Prompt("Введите первое число: ");
int numberTwo = Prompt("Введите второе число: ");
numberTwo = Validation(numberTwo);
Console.WriteLine(Exponetial(numberOne,numberTwo));