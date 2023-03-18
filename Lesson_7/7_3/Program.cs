// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.

int SumMass(int[,] array)
{
    int sumarray = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sumarray = sumarray + array[i,j];
        }
    return sumarray;
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
int sum = SumMass(mass);
Console.WriteLine($"Summa: {sum}");