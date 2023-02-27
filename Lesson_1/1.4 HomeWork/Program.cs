// Задача 1. Написать ппрограмму, которая на вход принимает два числа
// и выдает, какое большее, а какое меньшее. 1) a=5, b=7; 2) a=2, b=10; 3) a=-9, d=-3.

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

int max = a

if (b > max)
{
    Console.WriteLine(a "min");
    Console.WriteLine(b "max");
}
else
{
    Console.WriteLine(a "max");
    Console.WriteLine(b "min");
}