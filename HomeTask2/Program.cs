//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Ведите число а=");
int numbera = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число в=");
int numberb = int.Parse(Console.ReadLine());

if (numbera > numberb) {
    int result = numbera ;
    Console.WriteLine("Большее число = " + result);
    
}

else {
    Console.WriteLine("Большее число = " + numberb);
}
