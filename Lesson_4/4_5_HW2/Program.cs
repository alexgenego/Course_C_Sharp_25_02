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

// варианты

// 2. Напишите программу, которая принимает
//    на вход число и выдаёт сумму цифр в числе.


int SumNums_1(int num)
{
    int n_sum = 0;

    while (num > 0)
    {
        n_sum += num % 10;
        num /= 10;
    }
    return n_sum;
}

int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNums_1(num_1));

// --------------------------------- 2 вариант

int SumNums_2(int num)
{
    int n_sum = 0;

    for (; num != 0; num /= 10)
        n_sum += num % 10;

    return n_sum;
}


int num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNums_2(num_2));

// --------------------------------- 3 вариант
// https://shwanoff.ru/char-c-sharp/


double DigitSum(int num)
{
    string n = num.ToString();
    int length = n.Length;
    double sum = 0;

    for (int i = 0; i < length; i++)
    {
        double m = char.GetNumericValue(n[i]);
        sum += m;
    }

    return sum;
}

int n = int.Parse(Console.ReadLine()!); ;

Console.WriteLine(DigitSum(n));