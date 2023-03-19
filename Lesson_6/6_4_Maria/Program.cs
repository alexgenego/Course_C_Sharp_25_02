// Задача 4: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. Усложняем. Использовать по возможности - бинарный массив.
// void Print(int[] arr)

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matrix)
{
    int start = int.Parse(Console.ReadLine()!);
    int stop = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(start, stop);
        }
    }
    Console.WriteLine(matrix);
}
int[,] CopyMatrix(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    int[,] matrix2 = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            matrix2[i, j] = matrix[i, j];

    return matrix2;
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[num1, num2];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

int[,] matrix_2 = CopyMatrix(matrix);
PrintArray(matrix_2);
Console.WriteLine();
