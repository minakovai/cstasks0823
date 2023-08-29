// задача 20
// Написать программу которая
//1. Принимает на вход координаты двух точек
//2. Находит расстояние между точками в 2D пространстве

double FindDistance(int xA, int yA, int xB, int yB)
{
    return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
}


Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xCoorinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoorinateA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xCoorinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoorinateB = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(xCoorinateA, yCoorinateA, xCoorinateB, yCoorinateB);
Console.WriteLine($"{Math.Round(result, 2, MidpointRounding.ToZero)}");