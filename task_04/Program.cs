// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int max = 0;

Console.Write("Введите число a: ");
int numbera = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int numberb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c: ");
int numberc = Convert.ToInt32(Console.ReadLine());

if(numbera > max)
{
    max = numbera;
}
if(numberb > max)
{
    max = numberb;
}
if(numberc > max)
{
    max = numberc;
}

Console.WriteLine("max = " + max);