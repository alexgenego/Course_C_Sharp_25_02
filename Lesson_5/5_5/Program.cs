// Задача 4: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
void Print(int[] arr) // берет массив и выводит его в строку с пробелами
{
    int size = arr.Length; // определяем размер массива, созданного в цикле 2

    for (int i = 0; i < size; i++) 
        Console.Write($"{arr[i]} "); // чтение и вывод массива - интерполяция в строку
    Console.WriteLine(); // пробел между массивами (если их несколько)
}

int[] MassNums(int size, int from, int to) // формирует массив случайных чисел
{
    int[] arr = new int[size]; // указываем на формирование нового массива

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int[] PairsNum(int[] arr) // операции с массивом
{
    int size = arr.Length; // вводим "старый" массив
    int flex_size = size / 2 + size % 2; // определяем длину нового массивв
    int[] new_arr = new int[flex_size]; // новый массив с "00" по всей длине - заготовка

    for (int i = 0; i < size / 2; i++) // цикл для массивов с четным кол.членов, для умножения крайних
        new_arr[i] = arr[i] * arr[size - i - 1];
    
    if (size % 2 == 1) // условие записи среднего номера для нечетных массивов
        new_arr[flex_size - 1] = arr[size / 2];
    return new_arr;
}

int num = int.Parse(Console.ReadLine()!);    // ниже главная связка
int start = int.Parse(Console.ReadLine()!);  // все 3 строки - передают атрибуты в массив
int stop = int.Parse(Console.ReadLine()!);   // MassNum, а он в цикле 2 определяет size from to

int[] arr = MassNums(num, start, stop); // массив, сформированный во 2-м цикле, передан 
                                          // на хранение и дальнейшие действия (циклы 3, 1)  
int[] new_arr = PairsNum(arr);// новый массив цикл 3, воспринимаем и передаем функции
Print(arr);
Print(new_arr);
