﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решить без использования строк.

int num = new Random().Next(100, 1000); // генерируем случайное число в диапазоне от 100(включительно) до 1000(НЕвключительно)
int num1 = num/10;                      // выполняем целочисленное деление на 10, чтобы вторая цифра числа num оказалась последней
int num2 = num1%10;                     // определяем остаток от деления на 10
Console.WriteLine($"Вторая цифра числа {num} => {num2}");