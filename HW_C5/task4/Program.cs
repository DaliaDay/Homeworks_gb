// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс,
// минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив 
//и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что
// для этого дополнительно выполнить.

// Задача VERY HARD необязательная Имеется массив случайных целых чисел. Создайте массив, в который попадают числа, описывающие максимальную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.

// Пример:

// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]

// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5]

// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5]

int[] array = new int[7];
int index, min;
int sum = 0;
int median;
int median2;
int max = array[0];

void FillArray(int[] array)
{
    for (int i=0; i<array.Length;i++)
        array[i]=new Random().Next(1,10);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
Console.WriteLine();
}

void DifferenceMinMax(int[] array)
{ 
    min = array[0];
for(index = 0; index < array.Length; index++)
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
 Console.WriteLine($"Maximum Element -> {max}");
 Console.WriteLine($"Minimum Element -> {min}");
}

int ArithmeticMean(int[] array)
{
    
    for(index = 0; index < array.Length; index++)
    {
        sum += array[index];
    }
    int average = sum / array.Length;
    return average;
}

void Median(int[] array)
{
if(array.Length%2 !=0){
int size = array.Length/2;
int median = array[size];
Console.WriteLine($"Median -> {median}");
}
else{
    int size = array.Length/2;
median = array[size];
median2 = array[size - 1];
Console.WriteLine($"Median -> {median2}, {median}");
}

}




FillArray(array);
PrintArray(array);
DifferenceMinMax(array);
Console.WriteLine($"Arithmetic mean -> {ArithmeticMean(array)}");
Median(array);
int[,] Array = new int[,]{ {min, max}};
Console.WriteLine(Array);