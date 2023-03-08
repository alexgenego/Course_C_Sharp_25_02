// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.


void Massiv(int lenght)
{
    int[] arR = new int[lenght];
    for (int i=0; i<lenght; i++)
    {
        arR[i] = new Random().Next(2);
        Console.Write(arR[i]);
    }
}

Massiv(int.Parse(Console.ReadLine()!));