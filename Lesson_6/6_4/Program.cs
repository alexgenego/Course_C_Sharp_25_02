// Задача 4: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. Усложняем. Использовать по возможности - бинарный массив.
// void Print(int[] arr)
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    int start = int.Parse(Console.ReadLine()!);
    int stop = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i,j] = new Random().Next(start,stop);
                }
        }
        
}
void CopyMatrix(int[,] matr)
{
        //int[,] matr = new int[num1,num2];
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i,j] = matr2[i,j];
                Console.Write(matr2[i,j] + " ");
            }
        Console.WriteLine();
        }
}
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[num1, num2];

//int[,] matr = new int[i,j];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
CopyMatrix(matrix);
Console.WriteLine();