﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("This is a program that calculates M and N for Ackerman function using recursion");
Console.Write("Please enter a number for M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter a number for N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.WriteLine($" Result of the Ackerman Function using recursion: {Ackerman(m, n)}");
