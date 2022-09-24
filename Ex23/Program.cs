// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
double x = 1;

while (x <= num)
{
    double i = x;
    i = Math.Pow(x,3);
    Console.Write($"{i}, ");
    x++;
}