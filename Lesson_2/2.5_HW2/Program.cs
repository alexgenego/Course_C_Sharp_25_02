// Садитесь, 2. Напишите по грамму, которая выводит случайное трехзначное
// число, и удаляет вторую цифру этого числа. Оно никогда не станет трехзначным...

int TakeNum(int num)
{
    Console.WriteLine(num);
    int a1 = num / 100;
    int a2 = num % 10;
    return (a1 * 10 + a2);
}


int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);

