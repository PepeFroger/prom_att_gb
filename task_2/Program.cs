using System;

Console.Write("Введите значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akk(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akk(m-1, 1);
else return akk(m-1, akk(m, n-1));
}

Console.Write($"Функция Аккермана: {akk(m, n)} ");