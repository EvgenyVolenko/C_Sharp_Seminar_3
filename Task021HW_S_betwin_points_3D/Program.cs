// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координату Х точки А: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int bz = Convert.ToInt32(Console.ReadLine());

double s2 = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));

double s3 = Math.Round(Math.Sqrt(Math.Pow(s2 ,2) + Math.Pow(az - bz, 2)), 2);

Console.Write("Расстояние между точками = " + s3);