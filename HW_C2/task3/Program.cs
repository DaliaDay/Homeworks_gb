// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Please enter a number for weekdays 1 to 7 ");
int day = Convert.ToInt32(Console.ReadLine());
if(day > 0 && day <= 7){
    switch(day){
        case 1:
        Console.WriteLine("Monday and it is not a WEEKEND ");
        break;
        case 2:
        Console.WriteLine("Tuesday and it is not a WEEKEND ");
        break;
        case 3:
        Console.WriteLine("Wednsday and it is not a WEEKEND ");
        break;
        case 4:
        Console.WriteLine("Thursday and it is not a WEEKEND ");
        break;
        case 5:
        Console.WriteLine("Friday and it is not a WEEKEND ");
        break;
        case 6:
        Console.WriteLine("Saturday. YES IT IS A WEEKEND ");
        break;
        case 7:
        Console.WriteLine("Saturday. YES IT IS A WEEKEND ");
        break;
    }
}
else{
Console.WriteLine("Sorry but the number you entered is invalid :(");
}