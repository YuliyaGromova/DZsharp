// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine($"Первое число ({a}) больше второго числа ({b})");
}
else if (b>a)
{
    Console.WriteLine($"Второе число ({b}) больше первого числа ({a})");
}
else
{
    Console.WriteLine($"Первое число ({a}) равно второму числу ({b})");
}
