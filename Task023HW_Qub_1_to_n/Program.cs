// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
double qub;
int count = 1;

Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int[] array = new int[digit];


while (count <= digit)
{
    qub = Math.Pow(Convert.ToDouble(count), 3); // Можно конечно было просто count*coun*count. А так что-то новое.
    Console.WriteLine($"Куб числа {count} = {qub}");
    count++;
}