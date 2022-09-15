// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("insert number a");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("insert number b");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine("insert number c");
int numberC = int.Parse(Console.ReadLine()!);

int numberMax = numberA;

if (numberB > numberMax)
{
    numberMax = numberB;
}
if (numberC > numberMax)
{
    numberMax = numberC;
}

Console.WriteLine("maximum number is " + numberMax);