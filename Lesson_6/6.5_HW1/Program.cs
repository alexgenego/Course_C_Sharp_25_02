// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

string a;
int[] b = new int[100];
int i=0;
 
    while ((a = Console.ReadLine()!) != "end") //Получаем строку и проверяем ее содержание "end".
        b[i++] = Convert.ToInt32(a); //в строке нет "конца" - значит конвертим и пишем в массив
    for (int k = 0; k < i; k++) //вывод заполненных ячеек массива
    Console.Write($"{b[k]} ");
    
int PosMassiv(int[] b)
{
        //int[] b = b[i];
        // for (int i = 0 ; i < b.Length ; i++)
        //     if (b[i] > 0);
        //     i++;
        //     return i;
        return b.Length; 
                  
}
Console.WriteLine(b.Length);             
Console.ReadKey(true); //ключ ввода с клавиатуры
