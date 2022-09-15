// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("insert number a");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("insert number b");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA > numberB)
{
    Console.WriteLine("biggest number is " + numberA);
}
else if (numberA < numberB)
{
    Console.WriteLine("biggest number is " + numberB);
}
else 
{
    Console.WriteLine("both numbers are equal to " + numberA);
}