﻿// SЗадача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.

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
int Chechet(int [] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        num++;
    }
    return num;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] arr = MassNums(num, start, stop);
Print(arr);
Console.WriteLine (Chechet (arr));