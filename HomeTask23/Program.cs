// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    Console.WriteLine("Вывод кубов чисел от 1 до введённого числа " );
    return val;
}

void Cubing (int val)
{
    for (int count = 1; count < Math.Abs(val); count++)
    {
        Console.Write(Math.Pow(count, 3) + " ");
    }  
}
int number = Prompt("Введите число: ");
Cubing(number);