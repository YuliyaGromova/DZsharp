// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


void MasPrint(int[] array)
{
    Console.Write("[");
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}
Console.Write("Укажите длину массива (число должно быть больше 0): ");  //в задаче сказано, что длина массива =8, в тестовых данных длина отличается от 8
int size = Convert.ToInt32(Console.ReadLine());                         //пусть длину укажет пользователь
if (size > 0)                                                           //пользователь может ввести что хочет не смотря на инструкции
{
    Console.WriteLine("Вывод массива:");
    int[] Mas = new int[size];
    MasPrint(Mas);
}
else Console.WriteLine("Некорректное значение, длина массива не может быть меньше 1");
