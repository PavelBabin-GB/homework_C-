// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberB > numberA)
{
    Console.WriteLine("MAX = " + numberB);
    Console.WriteLine("Min = " + numberA);
}
else
{
    Console.WriteLine("MAX = " + numberA);
    Console.WriteLine("Min = " + numberB);
}
