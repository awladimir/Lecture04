// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int value = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");

int n1 = value / 10000;
int n2 = (value / 1000) % 10;
int n3 = (value / 100) % 10;
int n4 = (value / 10) % 10;
int n5 = value % 10;

Console.WriteLine($"Разбиваем по цифрам... {n1} {n2} {n3} {n4} {n5}");

if (n1 == n5 && n2 == n4)
{
    Console.WriteLine("Введенное число является полиндромом ");
}
else
{
    Console.WriteLine("Введенное число не является полиндромом ");
}
