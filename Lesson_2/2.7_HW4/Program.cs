// Задача 4. Напишите программу, которая принимает на вход цифру, 
// обозначающую дни недели, а на выходе определяет, выходной или нет.

string s_a = Console.ReadLine()!;

if (s_a == "1")
{
    Console.WriteLine("рабочий день");
}

else if (s_a == "2")
{
    Console.WriteLine("рабочий день");
}

else if (s_a == "3")
{
    Console.WriteLine("рабочий день");
}

else if (s_a == "4")
{
    Console.WriteLine("все еще рабочий день");
}

else if (s_a == "5")
{
    Console.WriteLine("не выходной еще");
}

else if (s_a == "6")
{
    Console.WriteLine("дожили. Выходной");
}

else if (s_a == "7")
{
    Console.WriteLine("еще выходной");
}

else
{
    Console.WriteLine("Бардак! Это другая неделя!");
}

//Console.WriteLine("Hello, World!");
