// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = Convert.ToInt32(System.Console.ReadLine());
    return temp;
}

int Natural(int a)
{
    int naturalNumber = a;
    if (naturalNumber < 1)
        naturalNumber = 2;
    return naturalNumber;
}

int Even(int a)
{
    if (a % 2 != 0)
        a = a + 1;
    return a;
}

void RangeLimitsCheck(int a, int b)
{
    if (a > b || b < 2)
    {
        Console.WriteLine("Верхняя граница должна быть больше 2 и больше нижней. Попробуйте ещё раз");
        Console.WriteLine();
        Execute();
    }
    
}

void EvenNumberRow(int a, int b)
{
    if (a < b + 1)
    {
        Console.Write($"{a} ");
        a = a + 2;
        EvenNumberRow(a, b);
    }
}

void Execute()
{

    Console.WriteLine("Программка выводит все чётные натуральные числа в заданном промежутке");
    int m = Prompt("Введите нижнюю границу диапазона: ");
    int n = Prompt("Введите верхнюю границу диапазона: ");
    RangeLimitsCheck (m, n);
    m = Natural(m);
    m = Even(m);
    EvenNumberRow(m, n);
}

Console.Clear();
Execute();
