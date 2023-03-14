// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Hello! Please Enter a number for the first variable ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now Please Enter a number for the second variable ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter a number for the third variable :) ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 && num1 > num3){
    Console.WriteLine("The max number here is " + num1);
    
}

else if(num2 > num1 && num2 > num3) {
Console.WriteLine("The max number here is " + num2);
} else
Console.WriteLine("The max number here is " + num3);

