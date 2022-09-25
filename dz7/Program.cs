System.Console.WriteLine("Введите число от 1 до 7");
string input = Console.ReadLine();
int number = int.Parse(input);
if (number == 1)
{
    System.Console.WriteLine("понедельник не является выходным");
}
else if (number == 2)
{
    System.Console.WriteLine("Вторник не является выходным");
}
else if (number == 3)
{
    System.Console.WriteLine("Среда не является выходным");
}
else if (number == 4)
{
    System.Console.WriteLine("Четверг не является выходным");
}
else if (number == 5)
{
    System.Console.WriteLine("Пятница не является выходным");
}
else if (number == 6)
{
    System.Console.WriteLine("Суббота  является выходным днем");
}
else if (number == 7)
{
    System.Console.WriteLine("Воскресенье  является выходным днем");
}