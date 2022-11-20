// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = Convert.ToInt32(System.Console.ReadLine());
    return temp;
}

double GenerateRandomDouble(int intMin, int intMax) // Генерирует случайное вещественное число в заданных границах.
{
    double temp = new Random().Next(intMin, intMax+1);
    if (temp > 0) temp -= new Random().NextDouble();
        else temp += new Random().NextDouble();
    temp = ((double)((int)(temp * 100))) / 100; // Округляем
    return temp;
}

double[,] CreateMatrix(int m, int n)
{
    double[,] table = new double[m, n];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = GenerateRandomDouble(-10, 10);
        }
    }
    return table;
}

void PrintMatrix(double[,] image)
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

void Execute()
{
int rows = Prompt("Enter quantity of rows ");
int columns = Prompt("Enter quantity of columns ");
double[,] matrix = CreateMatrix(rows, columns);
PrintMatrix(matrix);
}

Execute();