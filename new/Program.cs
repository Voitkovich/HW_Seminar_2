Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastnumber = number % 10;

if (number > 99) 
{
    while (number > 1000)
{
    number = (number / 10);
}
    Console.WriteLine($"Третья цифра заданного числа: {lastnumber}");
}
else 
{
    Console.WriteLine("Нет трёх чисел");
}