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




// 3. Напишите программу, которая принимает на вход число (N)
//    и выдаёт таблицу кубов чисел от 1 до N.


void Squares(int n)
{
    double[] nums = new double[n];
    int index = 0;

    Console.Write($"{n} -> ");

    while (index < n)
    {
        nums[index] = Math.Pow((index + 1), 3);
        Console.Write($"{nums[index]}, ");
        index += 1;
    }    
    Console.WriteLine();
}

Squares(int.Parse(Console.ReadLine()!));
