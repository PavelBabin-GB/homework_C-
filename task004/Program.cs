// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int nomberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int nomberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int nomberC = int.Parse(Console.ReadLine());

int max = nomberA;
if (nomberB > max) 
{
    max = nomberB;
}
if (nomberC > max) 
{
    max = nomberC;
}
   Console.WriteLine("Max = " + max);

