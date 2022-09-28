Console.WriteLine("Введите координату x1: ");
string input1 = Console.ReadLine();
double x1 = double.Parse(input1);

Console.WriteLine("Введите координату y1");
string input2 = Console.ReadLine();
double y1 = double.Parse(input2);

Console.WriteLine("Введите координату z1");
string input3 = Console.ReadLine();
double z1 = double.Parse(input3);

Console.WriteLine("Введите координату x2");
string input4 = Console.ReadLine();
double x2 = double.Parse(input4);

Console.WriteLine("Введите координату y2");
string input5 = Console.ReadLine();
double y2 = double.Parse(input5);

Console.WriteLine("Введите координату z2");
string input6 = Console.ReadLine();
double z2 = double.Parse(input6);

double d = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2));
d = Math.Round(d, 2);
Console.WriteLine($"Расстояние между кординатами: {d}");


