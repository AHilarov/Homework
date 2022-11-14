// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


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

int MinMaxSpread (int[] tempArray)
{
    int min = 0;
    int max = 0;
    for(int i = 0; i < tempArray.Length; i++)
    {
        if(tempArray[i] > max)
        {
            max = tempArray[i];
        }
        if(tempArray[i] < min)
        {
            min = tempArray[i];
        }
    }
    return max - min;
}

int len = 12;
int min = -10;
int max = 10;
int[] array = CreateArray(len, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"В указанном массиве разницу между максимальным и минимальным элементами составляет {MinMaxSpread(array)}");