// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please input first number");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input second number");
int secondnumber = Convert.ToInt32(Console.ReadLine());

int square = secondnumber*secondnumber;

if (firstnumber==square)
{
    Console.WriteLine("Yes! The first number is square of the second number");  
}
else
{
    Console.WriteLine("No! The first number is not a square of the second number");
}