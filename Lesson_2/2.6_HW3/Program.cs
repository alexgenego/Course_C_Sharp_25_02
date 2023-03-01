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
            for (int index = 0; index <7; index++)
                {
                num = num / 10;
                                
                if ((num /10) <= 100)
                    {
                        break;
                    }
                }
        
    }    
return (num % 10);
}
int result = TakeNum(new Random().Next(0, 10000000));
Console.WriteLine(result);

