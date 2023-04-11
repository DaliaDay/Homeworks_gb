// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[6];
void FillArray(int[] array)
{
    for (int i=0; i<array.Length;i++)
        array[i]=new Random().Next(-10,100);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    
}

void Sum(int[] array)
{
    int sum = 0;
    for(int index = 0; index<array.Length; index++)
    {
        if(index%2 != 0)
        {
            sum = sum + array[index];
        }
    }
   Console.Write($" -> {sum}");
}
FillArray(array);
PrintArray(array);
Sum(array);