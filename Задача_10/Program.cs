// Задача 10. Программа, которая принимает на вход трехзначное число
// А на выходе показывает вторую цифру этого числа.

Console.WriteLine ("Введите трехзначное число");
int A = Convert.ToInt32(Console.ReadLine());

int B = (A / 10) % 10;
{
    Console.WriteLine(B);
}

