// 17. На пишите программу, которая:
// 1. Принимает на вход точки (x и y),
// 2. x и y не равно 0
// 3. выдает номер четверти плоскости, в которой находится эта точка.

int Quarter(int x, int y) 
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y > 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoorinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoorinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoorinate, yCoorinate);
string result = quarter > 0
                ? $"Указанные координаты соответствуют четверти -> {quarter}"
                : "Введены некоректные данные";
Console.WriteLine(result);