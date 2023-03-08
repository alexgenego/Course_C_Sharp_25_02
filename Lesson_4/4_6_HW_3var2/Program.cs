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
    for (int i=0; i<lenght; i++)
    {
    Console.Write($"{array[i].ToString()}");
    //Console.WriteLine(array);
    }
    //Console.WriteLine(string.Join(",", array));
}
Massiv(int.Parse(Console.ReadLine()!));
//Massiv(8);



