// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

Console.WriteLine("Hello! Please Enter a number to read a second digit from the start of the number");
int num = Convert.ToInt32(Console.ReadLine());
int length = num.ToString().Length;
int result = 0;
if(length == 2){
    
    // result = num % 10;
    result = num%10;
    Console.WriteLine(result);
}
else if(num>=100){
     result = num%10;
    Console.WriteLine(result);
}
else{
    Console.WriteLine("Sorry but there is no second digit number in the entered number. Please enter a number > 10 ");

}
