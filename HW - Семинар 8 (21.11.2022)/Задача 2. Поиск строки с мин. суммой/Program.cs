// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = Convert.ToInt32(System.Console.ReadLine());
    return temp;
}

int[,] CreateMatrix(int m, int n)
{
    int[,] table = new int[m, n];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(0, 10);
        }
    }
    return table;
}

void PrintMatix(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] MatrixToArray(int[,] MatrixToSearch)
{
    int[] sumByRows = new int[MatrixToSearch.GetLength(0)];
    for (int i = 0; i < MatrixToSearch.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < MatrixToSearch.GetLength(1); j++)
        {
            rowSum = rowSum + MatrixToSearch[i, j];
        }
        sumByRows[i] = rowSum;
    }
    return sumByRows;
}

int minInArray(int[] array)
{
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minIndex])
            minIndex = i;
    }
    return minIndex;
}

void Execute()
{
    System.Console.WriteLine("Программа находит строку с наименьшей суммой элементов");
    int rows = Prompt("Введите количество строк ");
    int columns = Prompt("Введите количество колонок ");
    int[,] matrix = CreateMatrix(rows, columns);
    PrintMatix(matrix);
    Console.WriteLine();
    Console.WriteLine($"Наименьшая сумма элементов находится в строке номер {minInArray(MatrixToArray(matrix))}");
    Console.WriteLine();}

Execute();
