// Задача 1: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

//int Exp(int pr)
  //      {
    //        int Exp1 = pr;
        
//            for (int A, B; i < B; i++)
//            {
//                A = (A*A);
//            return pr;
//            }
//        }
//Console.WriteLine("Enter BASE A");
//int A = int.Parse(Console.ReadLine()!);
//Console.WriteLine("Enter EXPONENT B");
//int B = int.Parse(Console.ReadLine()!);
//int resalt = Exp(A);
//Console.WriteLine(resalt);

            Console.Write("Введите A: ");
            int num = int.Parse(Console.ReadLine()!);
            //int S = 1;
            Console.Write("Введите кол-во повторов B: ");
            int n = int.Parse(Console.ReadLine()!);
            int num_n = 1;
            for (int i = 0; i < n; i++)
            {
                num_n*= num;
            }
            Console.WriteLine(num_n);
