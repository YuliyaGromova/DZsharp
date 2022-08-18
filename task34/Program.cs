//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateMasRnd(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min,max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
    Console.WriteLine();
}

int CountEven(int[] array)                         //универсальный метод
{
    int countEven=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0) countEven++;           // 0 - число четное(так пишет википедия), поэтому если элемент массива =0, счетчик его считает
    }
    return countEven;
}


int num = new Random().Next(1, 100);              //пусть длина массива тоже генерируется случайным образом
int[] arr = CreateMasRnd(num,100,999);
PrintArray(arr);
int res=CountEven(arr);
Console.WriteLine($"Количество четных элементов массива: {res}");
