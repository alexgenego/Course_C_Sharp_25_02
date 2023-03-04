// Задача 1. Напишите программу, которая на вход принимает пятизначное
// число, а на выход показывает, является-ли оно палиндромом.

void Pal(int num)
{
    if (((num / 10000 == num % 10)) && (((num / 1000) % 10 == (num / 10) % 10)))
    {
        Console.WriteLine("Palindrome");
    }
    else
    {
        Console.WriteLine("Not Palindrome");
    }
}
Console.WriteLine("Enter a five-digit number");
int x = int.Parse(Console.ReadLine()!);
Pal(x);