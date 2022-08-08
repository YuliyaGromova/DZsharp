//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число в диапазоне 1-7 (включительно): ");
int number = Convert.ToInt32(Console.ReadLine());
while (number <1 || number >7){                                //пусть пользователь вводит число пока не введет верное
    Console.Write("В неделе 7 дней, введите число еще раз:");
    number = Convert.ToInt32(Console.ReadLine());
}
if (number>0 && number<6){                                      // проверяем рабочие дни
     Console.WriteLine($"{number}-й день недели рабочий");
}
else {                                                         // проверяем выходные дни
     Console.WriteLine($"{number}-й день недели выходной");
 }