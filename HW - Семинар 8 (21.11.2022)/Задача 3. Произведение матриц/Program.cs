// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{image[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] image1, int[,] image2)
{
    int r1 = image1.GetLength(0);
    int c1 = image1.GetLength(1);
    int r2 = image2.GetLength(0);
    int c2 = image2.GetLength(1);

    int temp = 0;
    int[,] newMatrix = new int[r1, c2];
    for (int i = 0; i < r1; i++)
    {
        for (int j = 0; j < c2; j++)
        {
            temp = 0;
            for (int k = 0; k < c1; k++)
            {
                temp += image1[i, k] * image2[k, j];
            }
            newMatrix[i, j] = temp;
        }
    }
    return newMatrix;
}


void Execute()
{
    string result = String.Empty;
    Console.WriteLine("Программа умножения матриц. Введите размеры матриц. ");
    int l = Prompt("Количество строк первой матрицы: ");
    int m = Prompt("Количество колонок первой матрицы: ");
    int n = Prompt("Количество колонок второй матрицы: ");
    int[,] matrix1 = CreateMatrix(l, m);
    int[,] matrix2 = CreateMatrix(m, n);
    Console.WriteLine("Первая матрица:");
    PrintMatix(matrix1);
    Console.WriteLine();
    Console.WriteLine("Вторая матрица:");
    PrintMatix(matrix2);
    Console.WriteLine();
    Console.WriteLine("Произведение матриц:");
    PrintMatix(MatrixMultiplication(matrix1, matrix2));
}

Execute();