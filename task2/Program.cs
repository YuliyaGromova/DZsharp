// Напишите программу, которая принимает на вход три числа и выдает максимальное из чисел.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int d = Convert.ToInt32(Console.ReadLine());
int maximum = a;
if (b>maximum)
{
    maximum = b;
}
if (d>maximum)
{
    maximum = d;
}
Console.WriteLine($"Максимальное число = {maximum} ");