// Задача 3. Напишите программу, которая на вход принимает число
// и выдает, является-ли число четным

int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0)
{
    Console.Write(a);
    Console.WriteLine(" четное");
}
else
{
    Console.Write(a);
    Console.WriteLine(" нечетное");
}

