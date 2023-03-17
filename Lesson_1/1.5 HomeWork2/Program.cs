// Напишите программу, которая принимает на вход 3 числа
// и выдает максимальное из них.

string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;
string s_c = Console.ReadLine()!;
int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.Write(max);

//Console.WriteLine("Hello, World!");
