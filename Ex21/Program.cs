// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
double[] tochkaA = new double[3];
double[] tochkaB = new double[3];

Console.Write("Введите X точки А: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y точки А: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z точки А: ");
double z1 = Convert.ToDouble(Console.ReadLine());
tochkaA[0]= x1;
tochkaA[1]= y1;
tochkaA[2]= z1;

Console.Write("Введите X точки B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y точки B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z точки B: ");
double z2 = Convert.ToDouble(Console.ReadLine());
tochkaB[0]= x2;
tochkaB[1]= y2;
tochkaB[2]= z2;

double dis = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
Console.WriteLine(Math.Round(dis,2));
Console.WriteLine($"Координаты точки А ({tochkaA[0]}, {tochkaA[1]}, {tochkaA[2]})");
Console.WriteLine($"Координаты точки B ({tochkaB[0]}, {tochkaB[1]}, {tochkaB[2]})");