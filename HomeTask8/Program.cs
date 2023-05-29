//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Ведите число ");
int per = 1;
int number = int.Parse(Console.ReadLine());
while ( per <= number) {
     if (per % 2 == 0) {
        Console.Write(per + " ");
      }
      per++;
}