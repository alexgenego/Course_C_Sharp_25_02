﻿// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно

void exploer(int int1, int int2)
{
    if (int1 % int2 == 0)
        Console.WriteLine("кратно");     

    else
        Console.WriteLine($"не кратно {int1 % int2}");
}
exploer (34, 5);