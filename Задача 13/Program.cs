//Программа, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.


        Console.WriteLine("Введите число");
        int A = Convert.ToInt32(Console.ReadLine());
        

        if (A > 99)
{
        
            while  ( A > 1000)
        {
            A = (A / 10);
        }
     
      Console.WriteLine($"Третья цифра в числе - {A % 10}");
} 
        else
    
        {
            Console.WriteLine("Третья цифра отсутствует");
        }
        

    
