// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            table[i, j] = new Random().Next(-9, 9);
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

void FindPosition (int[,] array, int r, int c)
{
    if (r > array.GetLength(0) || c > array.GetLength(0))
    {
    Console.WriteLine($"The position is out of matrix");
    return;
    }
    Console.WriteLine($"At the position [{r}, {c}] there is element {array[r-1,c-1]}."); 
}

void Execute()
{
    int rows = Prompt("Enter quantity of rows ");
    int columns = Prompt("Enter quantity of columns ");
    int[,] matrix = CreateMatrix(rows, columns);
    PrintMatix(matrix);
    int rowSearch = Prompt("Enter row number (starting from 1) ");
    int columnSearch = Prompt("Enter column number (starting from 1) ");
    FindPosition(matrix, rowSearch,columnSearch);
}

Execute();