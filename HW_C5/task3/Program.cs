// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[6];
void FillArray(int[] array)
{
    for (int i=0; i<array.Length;i++)
        array[i]=new Random().Next(1,100);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
Console.WriteLine();
}

void DifferenceMinMax(int[] array)
{ 
    int max = array[0];
    int min  = array[0];
for(int index = 0; index < array.Length; index++)
{ 
    if (array[index]>max)
    {
        max = array[index];
    }
    if (array[index]<min)
    {
        min = array[index];
    }  
}
int difference  = max - min;
 Console.WriteLine($"Maximum Element -> {max}");
 Console.WriteLine($"Minimum Element -> {min}");
 Console.WriteLine($"Difference between Max and Min is -> {difference}");
}




FillArray(array);
PrintArray(array);
DifferenceMinMax(array);