// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

int Ackerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;

    }
    else if ((n != 0) && (m == 0))
    {
        return Ackerman(n - 1, 1);
    }
        return Ackerman(n - 1, Ackerman(n, m - 1));
}

Console.WriteLine(Ackerman(a, b));