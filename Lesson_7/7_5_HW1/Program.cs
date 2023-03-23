﻿// Задача 1. Задать двумерный массив m x n и заполнить его 
// случайными вещественными числами.

void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
//, double from, double to
double[,] MassNums(int row, int column)
{
    double[,] arr = new double[row, column];
    Random random = new Random();
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(random.NextDouble()*100, 2);

    return arr;
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
// double start = double.Parse(Console.ReadLine()!);
// double stop = double.Parse(Console.ReadLine()!);
//double[,] mass = MassNums(num_row, num_column);
double[,] arr = MassNums(num_row, num_column);
// double[,] arr = MassNums(num_row, num_column, start, stop);
Print(arr);
