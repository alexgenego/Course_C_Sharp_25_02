// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.



int protectnomber(int num)
{
    int all_pr = 1;
    for (int i = 1; i <= num; i++)
        all_pr *= i;

    return all_pr;
}

int A = int.Parse(Console.ReadLine()!);
int result = protectnomber(A);
Console.WriteLine(result);
