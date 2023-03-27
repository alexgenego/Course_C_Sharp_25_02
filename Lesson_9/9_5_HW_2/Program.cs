// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

int Sum(int M, int N)
{
    if (M==N)
return N;
else return M + Sum(M + 1, N);
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Console.Write(Sum(num1,num2));
