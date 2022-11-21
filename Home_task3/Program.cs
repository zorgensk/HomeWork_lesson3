// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число не равное 0");
int num = Convert.ToInt32(Console.ReadLine());
while (num == 0)
{
    Console.WriteLine("Вы ввели не верное число !  Введите число не равное 0");
    num = Convert.ToInt32(Console.ReadLine()); 
}

if (num > 0)
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i} в кубе = {Math.Pow(i, 3)}");
    }
else
    for (int i = 1; i >= num; i--)
    {
        Console.WriteLine($"{i} в кубе = {Math.Pow(i, 3)}");
    }