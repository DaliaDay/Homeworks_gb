// Задача 11 - HARD На входе от пользователя целое число любой разрядности, надо удалить вторую цифру слева направо этого числа.

Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99)
{
    while(num > 99){
    num = num / 10;
}

int res = num - (num % 10);


Console.WriteLine($" Here is you third digit of the given number: {res}");
}

else
    Console.WriteLine($"  {num} -> There is no 3rd digit in the given number: ");

