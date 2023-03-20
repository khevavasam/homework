// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Promt(string gg) 
{
    
    System.Console.Write(gg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Promt ("Введите трехзначное число: ");
if (number < 100 || number > 999 )
{
    Console.WriteLine("Число которое вы ввели не является трехзначным");
    return;
}
Console.WriteLine($"Введенное число {number}");
int secondnumber = number / 10 % 10;
Console.WriteLine($"Вторая цифра {secondnumber}");
