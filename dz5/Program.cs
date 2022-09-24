Console.WriteLine("Введите трехзначное число");
string input = Console.ReadLine();
int number = int.Parse(input);
int seconddigit = (number/10) % 10;
Console.WriteLine(seconddigit);
