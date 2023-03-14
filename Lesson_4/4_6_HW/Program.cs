// Задача 3: Напишите программу, которая задаёт массив из
// 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции

void Massiv(int lenght)
{
    int[] arr = new int[lenght];
    for (int i=0; i<lenght; i++)
    {
            arr[i] = new Random().Next(8);
            //return arr[i];
        //Console.WriteLine(arr[i]);
    }
    //int[] arr2 = {1, 2, 3, 4, 5};
    PrintArray(arr, lenght);
}

void PrintArray(int[] array, int lenght)
{
    //Console.WriteLine(array.ToString());
    string[] arr = new string[lenght];
    for (int i=0; i<lenght; i++){}
    //{
    //Console.WriteLine(array[i].ToString());
    //Console.WriteLine(array);
    //}
    Console.WriteLine(string.Join(",", array));
}
Massiv(int.Parse(Console.ReadLine()!));
//Massiv(8);

// оптимальное решение

// 3. Напишите программу, которая задаёт массив из 8 элементов
//    случайными числами и выводит их на экран. Оформите заполнение массива
//    и вывод в виде функции (пригодится в следующих задачах)

void Print(int[] arr) // берет массив и выводит его в строку с пробелами
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] EightMass(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = EightMass(num, start, stop); // массив, сформированный во 2-м цикле, передан
                                          // на хранение и печать в int []  
Print(mass);

