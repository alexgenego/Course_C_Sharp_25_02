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
                    matrix[i,j] = new Random().Next(start,stop);
                }
        }
        Console.WriteLine(matrix);
}
//void CopyMatrix(int[,] matrix2)
//{
//         Array matrix2 = 
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 matrix = new int[i,j];
//                 Console.Write(matrix[i,j] + " ");
//             }
//         }
//         Console.WriteLine();
// }
//int start = int.Parse(Console.ReadLine()!);
//int stop = int.Parse(Console.ReadLine()!);
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[num1, num2];
//int[,] matrix2 = new int[num1, num2];
//int[,] matr = new int[i,j];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
//CopyMatrix(matrix2);
Console.WriteLine();
// Ниасилил..Код в 2 этапа делает матрицу n/m и заполняет ее случайными числами. 
// В 1 этап, чтобы сразу ввести количество строк и столбцов, и границы случайных чисел,
// не смог, но хоть работает. А переписать поэлементным копированием через цикл 
// в новый массив - не смог... Не могу определить массив -строка 31. И объединением 
// двух void-ов с циклами в один тоже не получается.