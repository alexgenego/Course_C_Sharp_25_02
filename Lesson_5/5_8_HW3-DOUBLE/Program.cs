// Задача 3: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов массива;
// Решена с подсказки Алексея. В 4-м методе застрял - смешал правила для Void и возвращаемых функций.
void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

double[] selectionSort(double[] arr2)
{
    for (int i = 0; i < arr2.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < arr2.Length; j++)
            {
            if(arr2[j] < arr2[minPosition]) minPosition = j;
            }
            double temporary = arr2[i];
            arr2[i] = arr2[minPosition];
            arr2[minPosition] = temporary;
    }
    return arr2;
}   
void DifMaxMin(double[] arr)
{
    int size = arr.Length;
    double result = arr[^1] - arr[0];
    Console.WriteLine(result);
} 

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
double[] mass = MassNums(num, start, stop);
Print(mass);
double[] arr2 = selectionSort(mass);
Print(arr2);
DifMaxMin(arr2);

