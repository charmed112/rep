// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
    {
    Console.Write("Введите b1: ");
    double b1 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите k1: ");
    double k1 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите b2: ");
    double b2 = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите k2: ");
    double k2 = double.Parse(Console.ReadLine() ?? "0");

    double x = (b2 - b1) / (k1 - k2);
    Console.WriteLine("x = " + x);
    double y = k1 * x + b1;
    Console.WriteLine("y = " + y);
    Console.WriteLine($"Точка пересечения с координатами: ({x}; {y})");

    Console.ReadKey();
}
