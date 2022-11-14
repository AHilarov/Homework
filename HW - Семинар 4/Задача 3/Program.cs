// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max+1);
    }
    return tempArray;
}

void PrintArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

int len = PromptInt("Введите оличество элементов в массиве: ");
int min = PromptInt("Введите минимальное число массива: ");
int max = PromptInt("Введите максимальное число массива: ");
int[] array = CreateArray(len, min, max);
PrintArray(array);