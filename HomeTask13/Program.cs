//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
if ( n < 100)
{
    Console.WriteLine("У числа " + n + " нет третьей цифры");
}
else
{
    while (n >=1000)
    {
        n = n / 10;
    }
    int thirdDigit = n % 10;
    Console.WriteLine("Третья цифра числа : " + thirdDigit);
}