// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] FillMass()
{
    string a;
    int[] b = new int[100];
    int i = 0;

    while ((a = Console.ReadLine()!) != "end") //Получаем строку и проверяем ее содержание "end".
        b[i++] = Convert.ToInt32(a); //в строке нет "конца" - значит конвертим и пишем в массив
    // for (int k = 0; k < i; k++) //вывод заполненных ячеек массива
    //     Console.Write($"{b[k]} ");
    return b;
}

int PosMassiv(int[] b)
{
    int count = 0;
    for (int i = 0; i < b.Length; i++)
        if (b[i] > 0)
            count++;

    return count;
}


int[] new_mass = FillMass();
int result = PosMassiv(new_mass);
Console.WriteLine(result);