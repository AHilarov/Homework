// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = Convert.ToInt32(System.Console.ReadLine());
    return temp;
}

int Natural(int a)
{
    if (a < 1)
        a = 1;
    return a;
}

void RangeLimitsCheck(int a, int b)
{
    if (a > b || b < 1)
    {
        Console.WriteLine(
            "Верхняя граница должна быть больше 1 и больше нижней. Попробуйте ещё раз"
        );
        Console.WriteLine();
        Execute();
    }
}

int NaturalNumbersSum(int a, int b)
{
    int sum = a;
    if (a == b + 1)
    {
        return 0;
    }
    return a + NaturalNumbersSum(a + 1, b);
}

void Execute()
{
    Console.WriteLine("Программка считает сумму натуральных чисел в заданном промежутке");
    int m = Prompt("Введите нижнюю границу диапазона: ");
    int n = Prompt("Введите верхнюю границу диапазона: ");
    RangeLimitsCheck(m, n);
    m = Natural(m);
    Console.WriteLine(NaturalNumbersSum(m, n));
}

Console.Clear();
Execute();