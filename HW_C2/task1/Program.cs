// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Hello! Please Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int digNum = num / 10;
int digNum2 = digNum % 10;
if (num > 99 && num <= 999){
    Console.WriteLine($"Here is the second digit of the three-digit number: {digNum2}");
}
else{
    Console.WriteLine("Please Enter only a three-digit number :)");
}