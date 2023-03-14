// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Hello! Please Enter a number for the first variable ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now Please Enter a number for the second variable ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2){
    Console.WriteLine("The max number here is " + num1);
    
}
else
Console.WriteLine("The max number here is " + num2);
