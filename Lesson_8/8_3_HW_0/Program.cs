// Задать ддвумерный массив из целых чисел. Программа 
// удаляяет строку и столбец, на которых наименьший элемент массива.

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

int[] MinNum(int[,] arr)
{
   int row = arr.GetLength(0);
   int column = arr.GetLength(1);
   int min_num = arr[0, 0];
  
   int[] indexes = new int[2]; // новый массив из 2-х элементов, представленных индексками минимального 
                                // элемента (i,j), см. ниже
   for (int i = 0; i < row; i++)
   {
        for (int j = 0; j < column; j++)
            if (min_num > arr[i, j])
            {
                min_num = arr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
   }
   Console.WriteLine(arr[indexes[0], indexes[1]]);
   return indexes;
}
void RowColumnDelit(int[,] arr, int a, int b)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    //int[] min_indexes = [a b];
    for (int i = 0; i < row; i++)
   {
        for (int j = 0; j < column; j++)
            if (a == i || b == j) continue;
            //if (min_indexes[0] == i || min_indexes[1] == j) continue;
            else Console.Write($"{arr[i, j],3}");
        Console.WriteLine();
   }
   Console.WriteLine();
   
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the bottom line: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the upper bound: ");
int stop = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(row_num, column_num, start, stop);
int[] min_num = MinNum(mass);
Print(mass);
int a = min_num[0];
int b = min_num[1];
// MinNum(min_num);
RowColumnDelit(mass, a, b);
//Print(min_indexes);