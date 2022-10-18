//Программа, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int A = Convert.ToInt32(Console.ReadLine());

        while (A > 99)

        {
            int B = (A / 10);
            int C = (B % 10);
        
            A = A / 10;
            
            Console.WriteLine($"Третья цифра в числе - {C}");
        }
    
        if (A < 100)
        {
            Console.WriteLine("Третья цифра отсутствует");
        }
    }
}