/*//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

int Count(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] /2 == 0) count+=1;
    }
    return count;    

}

int[] array = CreateRandomArray(5,100, 999);
ShowArray(array);

Console.WriteLine($"В массиве - {Count(array)} четных чисел");




//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

int SumDigit(int[] array)
{
    int sum = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if( i % 2 != 0)
        sum += array[i];
    }
return sum;
    
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях - {SumDigit(array)}");


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

int DiffDigit(int [] array)
{
    int max = 0;
    int min = array[1];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];
            for (int i = 0; i < array.Length; i++)    
                if (array[i] < min) min = array[i];
    
    return max-min;
}


int[] array = CreateRandomArray(5, 1, 99);
ShowArray(array);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива - {DiffDigit(array)}");