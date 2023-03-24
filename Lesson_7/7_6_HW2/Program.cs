// Задача 2. Написать программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или указание, что такого элемента нет.

void Print(int[,] arr)
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

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

string OccurrenceElement(int[,] arr, int numRow, int numCol, int row_num, int row_col)
{

    if (numRow < row_num && numCol < row_col && numCol > 0 && numRow > 0)
        {
            Console.Write($" {arr[numRow, numCol]} ");
        return "yes";
        }
        else
        {
          return "no"; 
        }
         
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

Console.Write("Enter a row index: ");
int numRow = int.Parse(Console.ReadLine()!);
numRow -= 1;
Console.Write("Enter a column index: ");
int numCol = int.Parse(Console.ReadLine()!);
numCol -= 1;
Console.Write($"{OccurrenceElement(mass, numRow, numCol, row_num, column_num)}"); 
