//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Ведите число а=");
int numbera = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число в=");
int numberb = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число c=");
int numberc = int.Parse(Console.ReadLine());

if (numbera > numberb) {
    int result = numbera ;
    if (result > numberc) {
        int maximum = result;
        Console.WriteLine("Максимальное из введённых чисел  = " + maximum);

    }
    else 
    Console.WriteLine("Максимальное из введённых чисел  = " + numberc);
    
}

else {
    Console.WriteLine("Максимальное из введённых чисел  = " + numberc);
}