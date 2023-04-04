// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

 Console.WriteLine("Hello!  This is a program to check whether the given 5 digit number is polindrome or not");
 Console.WriteLine(" Please enter a number:  ");
 int num = Convert.ToInt32(Console.ReadLine());
 int pol = num;
 int polindrome = 0;
 int result;

 

    if(num > 9999 && num < 100000)
{
    
    while (num > 0){
        
        result = num % 10;
        num = num/10;
        polindrome = polindrome * 10 + result;
    }
    if(pol == polindrome)
    {
        Console.WriteLine($"{polindrome}: The entered number is a polindrome number");
    }
    else
    Console.WriteLine($"{polindrome}:  The given number is not a polindrome ");
}
else
Console.WriteLine("Please enter 5 digit number only");

