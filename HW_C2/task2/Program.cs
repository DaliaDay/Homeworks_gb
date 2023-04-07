// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Hello! Please Enter a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res;
if(num > 999)
{
    while(num > 999){
    num = num / 10;
}
res = num % 10;
Console.WriteLine($" Here is you third digit of the given number: {res}");
}

else
    Console.WriteLine($"  {num} -> There is no 3rd digit in the given number: ");


