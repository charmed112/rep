System.Console.WriteLine("Введите число");
string input = Console.ReadLine();
int number = int.Parse(input);

int count = 1;
while (count <= number)
{
    Console.Write(Math.Pow(count, 3));
    if (count != number)
    Console.Write(",");
    count++;
    
}