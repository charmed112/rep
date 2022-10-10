// Пользователь вводит с клавиатуры число M, 
//потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("ВВедите колличество  вводимых чисел: " );
string input = Console.ReadLine();
int number = int.Parse(input);
int[] array = new int[number];
CreateArray(array);
int count1 = checkNumbers(array);
Console.WriteLine($"\nКолличество введенных чисел  > 0 : \"{count1}\"");
//создание массива ввод с клавы
void CreateArray(int[] array)
{
 for (int i = 0; i < array.Length; i++)
 {  Console.WriteLine($"ВВедите элемент массива c индексом {i}: " );
    array[i] = int.Parse(Console.ReadLine());
    
 }
var str = string.Join(" ", array);
    Console.WriteLine(str);
}
//сколько чисел больше 0 ввёл пользователь
int checkNumbers(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if  (array[i] > 0) count++;
}
return count;
}
