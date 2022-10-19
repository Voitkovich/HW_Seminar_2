//Программа, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int A = Convert.ToInt32(Console.ReadLine());
        int find = A % 10;

        if (A > 99)

        {
            while  ( A > 1000)
        {
            A = (A / 10);
        }
        
      Console.WriteLine($"Третья цифра в числе - {find}");
        }
        else
    {
        {
            Console.WriteLine("Третья цифра отсутствует");
        }
        }
}    
}
    
