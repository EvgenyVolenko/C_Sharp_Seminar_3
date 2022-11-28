// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число ");

int digit, znak;
int[] byDigit = new int[5];
int index = 0;

while (true)
{
    digit = Convert.ToInt32(Console.ReadLine());
    if (digit > 9999 & digit < 100000) break;
    else
        Console.WriteLine("Ну на русском же написано... ПЯТИЗНАЧНОЕ ЧИСЛО!!! Еще попытка");
}

while (digit > 0)
{
    znak = digit % 10;
    byDigit[index] = znak;
    digit = digit / 10;
    index++;
}

// Можно конечно ввести дополнительно 5 переменных в которые можно сохранить цифры,
// а потом сравнить значения первой с последней и второй с предпоследней.
// С помощью массива мне кажется красивее. 

if (byDigit[0] == byDigit[4] && byDigit[1] == byDigit[3]) 
{
    Console.WriteLine("Введенное число ПАЛИНДРОМ!");
}
else 
{
    Console.WriteLine("Введенное число НЕ палиндром!");
}