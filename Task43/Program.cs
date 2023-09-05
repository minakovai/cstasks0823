// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FunctionX(int b1, int k1, int b2, int k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FunctionY(int b2, int k2, double x)
{
    double y = (k2 * x) + b2;
    return y;
}

Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double functionX = FunctionX(b1, k1, b2, k2);
double functionY = FunctionY(b2, k2, functionX);

Console.WriteLine($"({functionX};{functionY})");