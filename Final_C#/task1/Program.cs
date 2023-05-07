// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Hello! this is a program that displays number from N to 1 ");
 Console.WriteLine("Now please enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < number; i++)
{ 
    Console.Write($"{number - i}, ");
}  