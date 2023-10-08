// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//  В псевдокоде функция Аккермана:
//     функция ack(n, m)
//     если n = 0
//         вернуть m + 1
//     иначе, если m = 0
//         вернуть ack (n - 1, 1)
//     еще
//         вернуть ack(n - 1, ack (n, m - 1))


int AckermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AckermanFunction(n - 1, 1);
    else return (AckermanFunction(n - 1, AckermanFunction(n, m - 1)));
}


Console.WriteLine("Введите два числа");
Console.Write("Введите 1-е число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int result = AckermanFunction(numberOne, numberTwo);
Console.WriteLine($"Функция Аккермана равна: {result}");