// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
// от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Hello! this is a program that displays the sum of a numbers from M to N ");
Console.WriteLine("Now please enter a number for M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a number for N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = numberM; i <= numberN; i++)
{  
    sum +=i;  
} 
Console.Write($"The sum of numbers between M to N is: {sum}");
 


