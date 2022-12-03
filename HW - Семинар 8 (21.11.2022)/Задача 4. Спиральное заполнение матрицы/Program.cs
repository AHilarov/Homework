// Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = Convert.ToInt32(System.Console.ReadLine());
    return temp;
}

void PrintMartix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:D2}\t");   
        }
        Console.WriteLine();
    }
}

void SpiralFillMatrix (int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int len = row*col;
    int i = 0;
    int j = 0;
    int k = 1;
    while (k<len+1)
    {
        matrix[i,j] = k;
        k++;
        if (i<=j+1 && i+j<col-1) j++;
        else if (i < j && i + j >= row - 1) i++;
        else if (i >= j && i + j > col - 1) j--;
        else i--;
    }
}

void Execute()
{
    Console.WriteLine("Спиральное заполнение квадратного массива произвольного размера");
    int digit = Prompt("Введите количество строк и столбцов: ");
    int[,] matrix = new int[digit, digit];
    SpiralFillMatrix(matrix);
    Console.WriteLine();
    PrintMartix(matrix);
}

Execute();