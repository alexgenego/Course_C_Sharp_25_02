// See https://aka.ms/new-console-template for more information
///Console.WriteLine("Hello, World!");

int[,] MassNums(int row, int column, int from, int to)
{
int[,] mass = new int[row, column];
    for (int i = 0;i<10;i++)
            {
                for (int j = 0; j < 5; j++)
                
                    {
                        mass[i, j] = new Random().Next(from, to);
                    }
            }
            return mass;
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Console.Write(mass);