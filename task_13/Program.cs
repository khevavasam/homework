// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Promt(string gg) 
{
    
    System.Console.Write(gg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Promt ("Введите число: ");
if (number < 100 )
{
    Console.WriteLine("В числе нету третьей цифры");
    return;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
{
Console.WriteLine(GetThirdRank(number));
}