// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
Console.WriteLine("Введите первое число: ");
int nomberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int nomberB = int.Parse(Console.ReadLine());
if (nomberB > nomberA)
{
    Console.WriteLine("MAX = " + nomberB);
    Console.WriteLine("Min = " + nomberA);
}
else
{
    Console.WriteLine("MAX = " + nomberA);
    Console.WriteLine("Min = " + nomberB);
}
