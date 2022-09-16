// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("insert number a");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("insert number b");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA > numberB)
{
    Console.WriteLine("the biggest number is " + numberA);
    Console.WriteLine("the lowest number is " + numberB);
}
else if (numberA < numberB)
{
    Console.WriteLine("the biggest number is " + numberB);
    Console.WriteLine("the lowest number is " + numberA);
}
else 
{
    Console.WriteLine("both numbers are equal to " + numberA);
}