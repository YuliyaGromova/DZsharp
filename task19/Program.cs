//Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


string polindrom(int chislo)     //универсальный метод определения является ли число палиндромом
{
    int count = 0;
    int num = chislo;
    int i = 1;
    int rebmun = 0;
    int n = 0;
    if (chislo < 0) return ("Отрицательное число не может являться палиндромом");
    {
        while (num != 0)
        {
            num = num / 10;
            count++;
        }
        num = chislo;
        while (i <= count)
        {
            n = chislo % 10;
            chislo = chislo / 10;
            rebmun = rebmun * 10 + n;
            i++;
        }
        if (num == rebmun)
        {
            return ($"Число {num} является палиндромом");
        }
        else
        {
            return ($"Число {num} НЕ является палиндромом");
        }
    }
}



Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10000 && number < 100000)                        //метод используется если число пятизначное
{
    string res = polindrom(number);
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Введенное число должно быть пятизначным");
}
