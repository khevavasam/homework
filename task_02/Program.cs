﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int max = 0;
int min = 0;

Console.WriteLine("введите число a");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b");
int numberb = Convert.ToInt32(Console.ReadLine());
if(numbera > numberb)
{
    max = numbera;
    min = numberb;
}
else
{
    max = numberb;
    min = numbera;
}
Console.WriteLine("max = " + max + " и " +"min =" + min);