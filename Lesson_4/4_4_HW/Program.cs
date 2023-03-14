// Задача 1: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

//Console.WriteLine("Enter BASE A");      //перенесены снизу.
//int A = int.Parse(Console.ReadLine()!); //перенесены снизу.
//Console.WriteLine("Enter EXPONENT B");  //перенесены снизу.
//int B = int.Parse(Console.ReadLine()!); //перенесены снизу.
//int Exp = 1;
//for (int i = 0; i < B; i++)
//        {
//            Exp *= A;
//        }
//        return Exp; - обрывает на первом шаге.

//Console.WriteLine(Exp);

    Console.Write("Введите A: ");
    int num = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во повторов B: ");
    int n = int.Parse(Console.ReadLine()!);
    int num_n = 1;
    for (int i = 0; i < n; i++)
    {
        num_n*= num;
    }
    Console.WriteLine(num_n);

    // 1. Напишите цикл, который принимает на вход два числа (A и B)
//    и возводит число A в натуральную степень B.

double PowNum(int a, int b)
{   
    double n_pow = 1; // степень может быть отрицательной, (и дробной), используем double
    int b_abs = Math.Abs(b); // по модулю
    
    for (int i = 1; i <= b_abs; i++)
    {
        if (b > 0)
            n_pow *= a; 
        else
            n_pow /= a; // как раз для отрицательной
    }  
    return n_pow;  
}

Console.WriteLine("Enter a number: ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter degree of number: ");
int num_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(PowNum(num_1, num_2));

