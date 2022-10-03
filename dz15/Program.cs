// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
CreateArray(array);
PrintArray(array);
//создание рандомного массива
void CreateArray(int[] array)
{
 Random randgenerator = new Random();
 for (int i = 0; i < 8; i++)
 {
    array[i] =randgenerator.Next(0,100);
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
