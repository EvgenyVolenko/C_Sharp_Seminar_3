// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X := 0 и Y := 0 и выдает номер четверти плоскости, в которой находится эта точка.

Console.Clear();

Console.Write("Введите координату Х точки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.Write("Ваша точка в четверти № 1.");
if (x < 0 && y > 0) Console.Write("Ваша точка в четверти № 2.");
if (x < 0 && y < 0) Console.Write("Ваша точка в четверти № 3.");
if (x > 0 && y < 0) Console.Write("Ваша точка в четверти № 4.");