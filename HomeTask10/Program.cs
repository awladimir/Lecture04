//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Ведите трхзначное число");
string result1 = Console.ReadLine();
int result = Convert.ToInt32(result1);
    if (result < 100 || result >= 1000)
    {
        Console.WriteLine("Вы ввели не трёхзначое чисдо , повторите ввод");
        return;
    }
int second = result / 10 % 10 ;
Console.WriteLine("Вторая цифра трёхзначного числа " + second );
