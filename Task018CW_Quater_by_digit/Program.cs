// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти для получения диаппазона координат: ");
string digit;
string diapX = "";
string diapY = "";

while(true)
{
    digit = Console.ReadLine();
    if (digit == "1" | digit == "2" | digit == "3" | digit == "4") break;
    else Console.WriteLine("Вы ввели что-то НЕ ТО!!! Попробуйте еще");
}

if (digit == "1") 
{
    diapX = "X > 0"; 
    diapY = "Y > 0";
}
if (digit == "2") 
{
    diapX = "X < 0"; 
    diapY = "Y > 0";
}
if (digit == "3") 
{
    diapX = "X < 0"; 
    diapY = "Y < 0";
}
if (digit == "4") 
{
    diapX = "X > 0"; 
    diapY = "Y < 0";
}

xy (digit, diapX, diapY);

void xy (string number, string diX, string diY)
{
    Console.WriteLine($"Вы в четверти № {number}, где {diX} и {diY}.");
}