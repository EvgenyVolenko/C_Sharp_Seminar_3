// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// Доп. задание
// Написать метод для разворота массива, 
// не используя память под дополнительный массив

Console.Clear();
int quad;
int count = 1;

Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int[] array = new int[digit];


while (count <= digit)
{
    quad = count * count;
    Console.WriteLine($"Квадраты числа {count} = {quad}");
    array[count - 1] = quad;
    count++;
}

Console.WriteLine("Значения прямого массива: ");
printArray(array);
Console.WriteLine();

razvorot(array);

Console.WriteLine("Значения развернутого массива:");
printArray(array);

void razvorot (int[] arr)
{
    int temp = 0;
    for (int i = 0; i <= arr.Length / 2; i++)
    {
        temp = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = temp;
    }
}

void printArray (int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + ", ");
    }
}