// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int a = num/10000;
int b = num%10;
int c = num/1000%10;
int d = num%100/10;

if ((num < 10000) || (num > 99999))
{
    Console.WriteLine("Введенное число не является пятизначным");
}
else if ((a==b) && (c==d)) Console.WriteLine("является палиндромом"); 
else Console.WriteLine("не является палиндромом");