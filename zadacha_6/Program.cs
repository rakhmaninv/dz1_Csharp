// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("insert number");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.WriteLine("your number is even");
}
else 
{
    Console.WriteLine("your number is odd"); 
}