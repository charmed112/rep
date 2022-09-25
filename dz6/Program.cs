  System.Console.WriteLine("введите число");
  int number = Convert.ToInt32(Console.ReadLine());
  string numbertext = Convert.ToString(number);
  if (numbertext.Length > 2)
  {
    Console.WriteLine(numbertext[2]);
  }
  else 
  {
    Console.WriteLine("третьей цифры нет");
  }
