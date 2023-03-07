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
