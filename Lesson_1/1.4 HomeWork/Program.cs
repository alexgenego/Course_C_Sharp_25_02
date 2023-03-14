// Задача 1. Написать ппрограмму, которая на вход принимает два числа
// и выдает, какое большее, а какое меньшее. 1) a=5, b=7; 2) a=2, b=10; 3) a=-9, d=-3.

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);


if (b > a)
{
    Console.Write("min = ");
    Console.WriteLine(a);
    Console.Write("max = ");
    Console.WriteLine(b);
}
else if (a == b)
{
    Console.Write(a);
    Console.Write(" = ");
    Console.WriteLine(b);
}
else
{
    Console.Write("min = ");
    Console.WriteLine(b);
    Console.Write("max = ");
    Console.WriteLine(a);
}