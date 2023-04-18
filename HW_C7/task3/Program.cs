// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//  элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Hello! this is a program that calculates arithmetic mean of an each row in the 2 dimensional array");
Console.WriteLine("Now please Enter a number for rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now Please enter a number for columns of an array");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

void FillArray(int[,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
    for(int j = 0; j < array.GetLength(1); j++)
    array[i,j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();
    }
}
int[] rsum = new int[rows];
void ArithmeticMean(int[,] array){
  int i, j, sum = 0, arithMean = 0;

  for (i = 0; i < array.GetLength(0); ++i) {
            for (j = 0; j < array.GetLength(1); ++j) {
 
                sum = sum + array[j, i];
                 arithMean = sum / array.GetLength(1);
            }
 
            // Print the row sum
            Console.WriteLine("Sum of the columns " + i + " = "
                              + sum + $"   Arithmetic mean -> {arithMean}");
 
            // Reset the sum
            sum = 0;
        }
}



Console.WriteLine();
FillArray(array);
PrintArray(array);
ArithmeticMean(array);
