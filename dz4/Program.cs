Console.WriteLine("Введите число");
string input1 = Console.ReadLine();
int n = int.Parse(input1);
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);