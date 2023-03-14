// Задача 1. Напишите программу, которая на вход принимает пятизначное
// число, а на выход показывает, является-ли оно палиндромом.

//void Pal(int num)
//{
//    if (((num / 10000 == num % 10)) && (((num / 1000) % 10 == (num / 10) % 10)))
//    {
//        Console.WriteLine("Palindrome");
//    }
//    else
//    {
//        Console.WriteLine("Not Palindrome");
//    }
//}
//Console.WriteLine("Enter a five-digit number");
//int x = int.Parse(Console.ReadLine()!);
//Pal(x);

//___________________________________________________

// 1. Напишите программу, которая принимает на вход
//    пятизначное число и проверяет, является ли оно палиндромом.

string Palindrome(int n)
{  
    int num = 10000; // определяем вспомогателное число - делитель для 1-го шага - цикл while
    if (n > 100000 || n < 10000)
        return "The number is not five-digit!";
    while (num > 1) // цикл с уменьшением n и num.
    {
        if (n / num % 10 != n % 10)
            return "no";
        n /= 10; //шаг для n
        num /= 100; // шаг для num, с учетом уменьшения n на 1 (предыдущее деление n на 10)
    }    
    return "yes";
}

//Console.WriteLine(Palindrome(int.Parse(Console.ReadLine()!)));

//__________________________________________________________
// Через строки

void Palindrome_1(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "yes"; //Атрибут [Flags] необязательный и используется для красивого вывода при вызове .ToString():
    
    while (i < size / 2)
    {
        if (num[i] != num[size - i]) 
        {
            flag = "no";
            break;
        }        
        i += 1;
    }    
    Console.WriteLine($"{n} -> {flag}");
}

Palindrome_1(14212);
Palindrome_1(23432);
Palindrome_1(12821);
Palindrome_1(1248421);
Palindrome_1(12488421);