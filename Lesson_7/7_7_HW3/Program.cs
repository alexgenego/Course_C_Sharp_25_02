// Задать двумерный массив из целых чисел.
// Найти среднее арифметическое в каждом столбце

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

double[,] MassNums(int row, int column)
{
    double[,] arr = new double[row, column];
    Random random = new Random();
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(random.NextDouble()*100, 0);

    return arr;
}

string meanColumn(double[,] arr, int num_row, int num_column)
{
double sum = 0;
double mean = 0;

for (int i = 0; i < num_column; i++)
    {
    for (int j = 0; j < num_row; j++)
            {
                sum += arr[j, i];
                mean = sum / num_row;
            }
            //Console.WriteLine();
            Console.Write(mean.ToString("n2") + " ");
            sum = 0;
            //mean = 0;
            
    }
    return "ColumnSum";
}

Console.Write("Enter the number of rows: ");
int num_row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int num_column = int.Parse(Console.ReadLine()!);
double[,] arr = MassNums(num_row, num_column);
Print(arr);
Console.WriteLine($"{meanColumn(arr, num_row, num_column)}");
Console.WriteLine();