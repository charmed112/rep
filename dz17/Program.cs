//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] array = new int[5];
CreateArray(array);
PrintArray(array);
int count1 = nonEvenNumbers(array);
Console.WriteLine($"\nСумма не четных чисел в массиве: \"{count1}\"");
//не четные числа в массиве 
int nonEvenNumbers(int[] array)
{int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 1)
    sum+=array[i];
    }
    return sum;
}
//создание массива
void CreateArray(int[] array)
{
 Random randgenerator = new Random();
 for (int i = 0; i < 5; i++)
 {
    array[i] =randgenerator.Next(1,10);
 }
}
//вывод массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}