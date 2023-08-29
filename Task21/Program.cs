// Задача 21. Напишите программу, которая:
// 1. Принимает на вход координаты двух точек
// 2. находит расстояние между ними в 3D пространстве



double FindDistance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
}

Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
int xcoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ycoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zcoordinateA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int xcoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ycoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zcoordinateB = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(xcoordinateA, ycoordinateA, zcoordinateA, xcoordinateB, ycoordinateB, zcoordinateB);
Console.WriteLine($"{Math.Round(result, 2, MidpointRounding.ToZero)}");