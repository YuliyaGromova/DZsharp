// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях (индексах).
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] CreateMasRnd(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Массив: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
    Console.WriteLine();
}

int SumUnevenIndex(int[] array)
{
    int sumUneven = 0;
    for (int i = 1; i < array.Length; i += 2)   // начинаем проверять массив с индекса 1, и увеличиваем индекс на 2, чтобы каждый следующий индекс был нечетным
    {
        sumUneven += array[i];
    }
    return sumUneven;
}

Console.Write("Укажите длину массива:");
int num = Convert.ToInt32(Console.ReadLine());
//int num = new Random().Next(1, 10);              //для проверки: длина массива генерируется случайным образом
if (num < 1) Console.WriteLine("Введенное значение некорректно. Длина массива не может быть меньше 1");
else if (num == 1) Console.WriteLine("Решение задачи не имеет смысла, т.к в массиве нет элементов стоящих на нечетных индексах");
else
{
    int[] arr = CreateMasRnd(num, -100, 100);
    PrintArray(arr);
    int sum=SumUnevenIndex(arr);
    Console.WriteLine($"Cумма элементов массива, стоящих на нечетных позициях => {sum}");
}