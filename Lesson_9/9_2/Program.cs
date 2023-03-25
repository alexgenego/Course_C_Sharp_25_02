// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.


// int ValuesSet(int N)
// {
//     if (N == 0) return 0;
//     return ValuesSet(N / 10) + N % 10;
// }

// int num = int.Parse(Console.ReadLine()!);
// ValuesSet(num1, num2);
// Console.WriteLine(ValuesSet(num));



int ValueSet(int N)
{
    if (N == 0) return 0;
    return ValueSet(N / 10) + N % 10;
}

int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(ValueSet(num));