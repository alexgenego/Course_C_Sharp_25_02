// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.


void Massiv(int leght)
{
    int[] R = new int[leght];
    for (int i=0; i<leght; i++)
    {
        R[i] = new Random().Next(2);
        Console.Write(R[i]);
    }
}

Massiv(int.Parse(Console.ReadLine()!));