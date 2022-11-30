// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = Convert.ToInt32(System.Console.ReadLine());
    return temp;
}

int Ackermann(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    if (numN == 0 && numM > 0)
        return Ackermann(numM - 1, 1);
    if (numM > 0 && numN > 0)
        return Ackermann(numM - 1, Ackermann(numM, numN - 1));
    return Ackermann(numM, numN);
}

void Execute()
{
    Console.WriteLine("Функция Аккермана ");
    int m = Prompt("Введите первое число (m): ");
    int n = Prompt("Введите второе число (n): ");
    Console.WriteLine(Ackermann(m, n));
}

Console.Clear();
Execute();
