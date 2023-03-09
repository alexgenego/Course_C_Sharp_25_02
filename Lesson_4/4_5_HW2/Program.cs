// Задача 2: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.;

int SumNum1(int num)
{
    int sum = 0;
    for(int i = 0 ; num > 0 ; i++)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum1(A));