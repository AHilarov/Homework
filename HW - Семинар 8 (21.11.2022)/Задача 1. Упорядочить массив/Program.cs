// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void MatrixRowsSort(int[,] MatrixToSort)
{
    for (int i = 0; i < MatrixToSort.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixToSort.GetLength(1); j++)
        {
            int k = j;
            for (k = 0; k < MatrixToSort.GetLength(1) - j - 1; k++)
            {
                if (MatrixToSort[i, k] < MatrixToSort[i, k + 1])
                    (MatrixToSort[i, k], MatrixToSort[i, k + 1]) = 
                        (MatrixToSort[i, k + 1], MatrixToSort[i, k]);
            }
        }
    }
}

void Execute()
{
    int rows = Prompt("Enter quantity of rows ");
    int columns = Prompt("Enter quantity of columns ");
    int[,] matrix = CreateMatrix(rows, columns);
    PrintMatix(matrix);
    Console.WriteLine();
    MatrixRowsSort(matrix);
    PrintMatix(matrix);
}

Execute();
