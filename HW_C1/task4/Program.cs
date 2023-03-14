// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Hello! Please Enter a number to represent all the even number form 0 to number N");
int num = Convert.ToInt32(Console.ReadLine());
int even_num = 1;
while(even_num < num){
    Console.WriteLine($"-> {even_num+1}" );
    even_num += 2;
}
// Console.WriteLine($"The collection of even numbers are:  {even_num}");
