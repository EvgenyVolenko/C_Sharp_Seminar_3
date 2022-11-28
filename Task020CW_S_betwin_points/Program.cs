// Задача 20: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();

Console.Write("Введите координату Х точки А: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int by = Convert.ToInt32(Console.ReadLine());

double s = Math.Round(Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2)), 2);

Console.Write("Расстояние между точками = " + s);