// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.

//string Deci_to_Dubl(int num)
//{
//    string resalt="";
//    while (num_1>0)
//    {
//        resalt = num_1 % 2 + resalt;
//        num_1 / 2;
//    }
//}
//return resalt;

//Console.ReadLine(Deci_to_Dubl(12))!);


// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.

string convert(int num_1)
{
    string rezult = "";
    while (num_1 > 0)
    {
        rezult = num_1 % 2 + rezult;
        num_1 = num_1 / 2;
    }
    return rezult;
    }
Console.WriteLine (convert(12));