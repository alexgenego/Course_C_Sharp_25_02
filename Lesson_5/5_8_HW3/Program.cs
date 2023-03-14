// Задача 3: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным элементов массива;
// Решена с подсказки Алексея. В 4-м методе застрял - смешал правила для Void и возвращаемых функций.
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

int[] selectionSort(int[] arr2)
{
    for (int i = 0; i < arr2.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < arr2.Length; j++)
            {
            if(arr2[j] < arr2[minPosition]) minPosition = j;
            }
            int temporary = arr2[i];
            arr2[i] = arr2[minPosition];
            arr2[minPosition] = temporary;
    }
    return arr2;
}   
void DifMaxMin(int[] arr)
{
    int size = arr.Length;
    int result = arr[^1] - arr[0];
    Console.WriteLine(result);
} 

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, start, stop);
Print(mass);
int[] arr2 = selectionSort(mass);
Print(arr2);
DifMaxMin(arr2);
