// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write($"{image[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// double RowMean (int[,] image, int c)  // это был пробный код расччета срднего по указанному столбцу
// {
//     double mean = 0;
//     int count = 0;
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//        mean = mean + image[i, c];
//        count++;
//     }
//     mean = mean / count;
//     return mean;
// }

void RowsMeans(int[,] image, double[] means, int r, int c)
{
    double mean = 0;
    for (int j = 0; j < c; j++) //пока индекс меньше количества столбцов
    {
        for (int i = 0; i < r; i++)
        {
            mean = mean + image[i, j];
        }
        mean = mean / r;
        means[j] = mean;
        mean = 0;
    }
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]:F2}\t");
        position++;
    }
}

void PrintLine(int width)
{
    int index = 0;
    while (index < width)
    {
        Console.Write($"{"______"}\t");
        index++;
    }
    Console.WriteLine();
}

void Execute()
{
    int rows = Prompt("Enter quantity of rows ");
    int columns = Prompt("Enter quantity of columns ");
    int[,] matrix = CreateMatrix(rows, columns);
    PrintMatix(matrix);
    double[] arrayMeans = new double[columns];
    RowsMeans(matrix, arrayMeans, rows, columns);
    PrintLine(columns);
    PrintArray(arrayMeans);
}

Execute();
