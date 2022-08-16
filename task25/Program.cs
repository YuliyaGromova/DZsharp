//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Вкакую степень возвести число? ");
int step = Convert.ToInt32(Console.ReadLine());

string PowerNumber(int number, int stepen)
{
    double res = 1;
    if (number != 0)
    {
        if (stepen > 0)
        {
            for (int i = 0; i < stepen; i++)
            {
                if (stepen > 0) res = res * number;
            }
        }
        if (stepen < 0) 
        {
            for (int i = 0; i < -stepen; i++) res = res / number;
        }
    }
    else return("Возведение числа 0 в степень не имеет смысла");
return ($"Число {number} в степени {stepen} => {Math.Round(res,4, MidpointRounding.ToZero)}");
}

string result = PowerNumber(num, step);
Console.WriteLine(result);