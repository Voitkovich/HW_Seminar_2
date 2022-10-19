// программа, которая принимает на вход цифру, 
// обозначающую день недели и проверяет, являеся ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели");
int dayNum = Convert.ToInt32(Console.ReadLine());

if (dayNum == 6 || dayNum == 7)
{
    Console.WriteLine("Этот день выходной!");
}
else if (dayNum < 1 || dayNum > 7)
{
    Console.WriteLine("Это вовсе не день недели!");
}
else
{
    Console.WriteLine("Это будний день.");
}
