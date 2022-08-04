// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num%2==0)
{
   Console.WriteLine($"Число {num} является четным");
}
else
{
   Console.WriteLine($"Число {num} не является четным");
}
