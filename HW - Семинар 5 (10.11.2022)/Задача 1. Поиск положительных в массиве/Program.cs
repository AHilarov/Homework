// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int length, int min, int max) // метод создания массива
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max+1);
    }
    return tempArray;
}

void PrintArray(int[] intArray)  //метод вывода массива
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

int CountEven (int[] tempArray)
{
    int count = 0;
    for(int i = 0; i < tempArray.Length; i++)
    {
        if(tempArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int len = 12;
int min = 100;
int max = 999;
int[] array = CreateArray(len, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"В указанном массиве {CountEven(array)} чётных чисел");