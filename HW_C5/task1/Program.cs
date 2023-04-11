// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int count = 0;
int[] array = new int[5];
void FillArray(int[] array)
{
    for (int i=0; i<array.Length;i++)
        array[i]=new Random().Next(99,1000);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    
}

int CountEvenNumber(int[] array)
{
    
    for(int index = 0; index<array.Length; index++)
    {
    if(array[index]%2 ==0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Hello! This is a program that counts how many even 3 digits number in he array.");
FillArray(array);
PrintArray(array);
Console.Write($" -> {CountEvenNumber(array)} even numbers");