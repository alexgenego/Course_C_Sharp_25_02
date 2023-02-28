// Задача3. Программа выводит 3-ю цифру заданного числа
// или сообщает, что ее нет (вообще нет третьей цифры...)

int TakeNum(int num)
{
    Console.WriteLine(num);
    {
        if  (num / 100 == 0)
            Console.WriteLine("Нет третьей цифры! Караул!!");
        
        else
            //(num = (num / 100));
            while ((num /100) / 10 > 0)
            {
                num = (num / 100) % 10;
            }
        
    }    
return (num);
}
int result = TakeNum(new Random().Next(0, 1000000));
Console.WriteLine(result);

