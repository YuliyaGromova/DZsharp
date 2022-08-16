// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

string SumNumbers(int num){
int numb=num;
int last=0;
int summa=0;
if (num<0) num=-num;
while (num>0)
{
    last=num%10;
    num=num/10;
    summa+=last;
}
return($"Сумма цифр числа {numb} => {summa}");
}

string res = SumNumbers(number);
Console.WriteLine(res);