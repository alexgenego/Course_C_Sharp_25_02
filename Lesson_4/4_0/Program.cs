// Напишите программу, принимающую число N и выдающую сумму от 1 - N

Int SumNum(int num);
{
    int all_sum = 0
    for (i=1, i <= num, i++);
        all_sum += i;
    
    return all_sum
}
int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);