// SЗадайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

int[,] MatrixMult(int[,] arr1, int[,] arr2)
{
    int row_1 = arr1.GetLength(0);
    int column_1 = arr1.GetLength(1);

    int row_2 = arr2.GetLength(0);
    int column_2 = arr2.GetLength(1);

    int[,] mult_matrix = new int[row_1, column_1];
    if (column_1 != row_2) return mult_matrix;
    else if (column_1 == row_2)
        mult_matrix = new int[row_1, column_2];

    for (int i = 0; i < row_1; i++)
    {
        for (int j = 0; j < column_2; j++)
        {
            for (int p = 0; p < column_1; p++)
            mult_matrix[i, j] += arr1[i, p] * arr2[i, p];
        }
    }
    return mult_matrix;
}

Console.Write("Enter the number of rows 1: ");
int row_1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns 1: ");
int column_1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of rows 2: ");
int row_2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns 2: ");
int column_2 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the bottom line: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the upper bound: ");
int stop = int.Parse(Console.ReadLine()!);
int[,] arr1 = MassNums(row_1, column_1, start, stop);
Print(arr1);
int[,] arr2 = MassNums(row_2, column_2, start, stop);
Print(arr2);
int[,] result_matrix = MatrixMult(arr1, arr2);
Print(result_matrix);