// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях;

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int SumChet(int [] arr)
{
    int odd;
    odd = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
            odd += arr[i];
    }
    return odd;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] arr = MassNums(num, start, stop);
Print(arr);
Console.WriteLine (SumChet (arr));