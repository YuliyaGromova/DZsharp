// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateMasRnd(int size, int min, int max)
{
    int[] array = new int[size];
    double[] arrayDob = new double[size];
    double[] BigDob = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
        arrayDob[i] = rnd.NextDouble();
        BigDob[i] = Math.Round(array[i] * arrayDob[i], 1, MidpointRounding.ToZero); //округляем до одного знака после запятой, как в тестовом примере
    }
    return BigDob;
}

void PrintArray(double[] array)
{
    Console.Write("Массив: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1) Console.Write("|");   // поменяла разделитель, т.к дробные числа имеют разделитель ,
    }
    Console.Write("]");
    Console.WriteLine();
}

double RaznizaMaxMin(double[] array)
{
    double minimum = array[0];
    double maximum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (maximum < array[i]) maximum = array[i];
        if (minimum > array[i]) minimum = array[i];
    }
    return Math.Round(maximum - minimum, 1, MidpointRounding.ToZero);  //результат так же округляем до 1 знака после запятой, как в примере (иначе будет 14 знаков после запятой)
}

int num = new Random().Next(1, 10);              //пусть длина массива тоже генерируется случайным образом
double[] arr = CreateMasRnd(num, -100, 100);
PrintArray(arr);
double res = RaznizaMaxMin(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива => {res}");