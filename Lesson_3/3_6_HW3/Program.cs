// Напишите программу, которая на входе принимает число (N), 
// и выдает таблицу кубов чисел от 1 до N

void Kub(int num)
{
    for(int i = 1 ; i <=num; i++)
    {
        Console.Write(Math.Pow(i, 3)  +", ");
    }

}

int x = int.Parse(Console.ReadLine()!);
Kub(x);
