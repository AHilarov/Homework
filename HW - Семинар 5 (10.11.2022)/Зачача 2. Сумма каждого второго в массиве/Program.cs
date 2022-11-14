// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int length, int min, int max) // метод создания массива
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max + 1);
    }
    return tempArray;
}

void PrintArray(int[] intArray) //метод вывода массива
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

int SumOddIndex(int[] tempArray) //метод считает сумму элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 1; i < tempArray.Length; i = i + 2)
    {
        sum = sum + tempArray[i];
    }
    return sum;
}

int len = 9;
int min = 0;
int max = 100;
int[] array = CreateArray(len, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumOddIndex(array)}");
