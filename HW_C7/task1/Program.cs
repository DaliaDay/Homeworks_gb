// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
Console.WriteLine("This is a program that displays 2 dimensional array");
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random().Next(-10, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

Console.WriteLine("Please Enter a number for rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now Please enter a number for columns of an array");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
Console.WriteLine();
FillArray(array);
PrintArray(array);