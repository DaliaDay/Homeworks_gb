// адача 50. Напишите программу, которая на вход принимает значение элемента в двумерном 
// массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
Console.WriteLine("Hello! This is a program that searches for the number and shows it's index in the 2 dimension array");
Console.WriteLine("Please Enter a number to find it's index: ");
int num = Convert.ToInt32(Console.ReadLine());
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

void FindNum(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(num == array[i,j])
                {
                    num = array[i,j];
                    Console.WriteLine($"The index of the element: {num}  -> [{i},{j}]");
                    
                } 
                 
        }
        Console.WriteLine("Number does not exist in the array"); 
        
               
}



int rows = 3;
int cols = 3;
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
FindNum(array);