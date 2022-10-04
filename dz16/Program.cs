//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int [10];
CreateArray(array);
PrintArray(array);
int count1 = EvenNumbers(array);
Console.WriteLine($"\nКолличество четных чисел в массиве: \"{count1}\"");
//четные числа в массиве 
int EvenNumbers(int[] array)
{int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
    count++;
    }
    return count;
}
//создание массива
void CreateArray(int[] array)
{
 Random randgenerator = new Random();
 for (int i = 0; i < 10; i++)
 {
    array[i] =randgenerator.Next(100,1000);
 }
}
// вывод масива на экран 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}