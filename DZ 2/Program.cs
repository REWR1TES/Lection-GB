﻿//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();

int max;
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.Write("Введите Третье число: ");
int numberC = int.Parse(Console.ReadLine()!);

if (numberA > numberB)
{
    max = numberA;
}

else
{
    max = numberB;
}

if (numberC > max)
{
    max = numberC;
}

Console.Write($"Число {max} больше всех чисел");