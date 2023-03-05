// Написать программу, определяющую расстояние между 
// двумя точками в пространстве
// РЕШЕНО В ОБЩЕМ ВИДЕ - ПРОВЕРКА1 А(3, 6, 8) Б(2, 1, -7) -> 15.84
//                       ПРОВЕРКА2 А(7, -5, 0) Б(1, -1, -9) -> 11.53

double example (double x1, double y1, double z1, double x2, double y2, double z2)
{
return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
}



Console.WriteLine("Enter x1 for the point 1");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter y1 for the point 1");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter z1 for the point 1");
double z1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter x2 for the point 2");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter y2 for the point 2");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter z2 for the point 2");
double z2 = double.Parse(Console.ReadLine()!);
Console.WriteLine(example(x1, y1, z1, x2, y2, z2));