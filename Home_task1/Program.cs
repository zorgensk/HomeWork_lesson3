// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите массив чисел");
int num = Convert.ToInt32(Console.ReadLine());
string array = Convert.ToString(num);
if (array[0] == array[4] && array[1] == array[3])
 {
    Console.WriteLine("Является палиндромом.");
 }
 else
    Console.WriteLine("Не является палиндромом.");
