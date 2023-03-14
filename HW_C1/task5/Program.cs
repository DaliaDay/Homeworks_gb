// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

Console.WriteLine("Hello! Please Enter a number to read a second digit from the start of the number");
int num = Convert.ToInt32(Console.ReadLine());
List<int> lst = new List<Int32>(num);

if(num >= 10){
    
    Console.WriteLine(lst[1]);
}
else{
    Console.WriteLine("Sorry but there is no second digit number in the entered number. Please enter a number > 10 ");

}
