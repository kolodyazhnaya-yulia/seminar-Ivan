//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите третье число");
int numberС = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB & numberA>numberС)
{
    Console.WriteLine(numberA);
    }
if(numberB > numberA & numberB > numberС )
{
    Console.WriteLine(numberB);
    }
    else
    {
        Console.WriteLine(numberС);
    }