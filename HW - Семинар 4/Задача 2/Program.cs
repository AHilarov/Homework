// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int digitsSum (int digit)
{
    int sum = 0;
    while (digit > 0)
    {
        sum = sum + digit % 10;
        digit = digit / 10;
    }
    return sum;
}

int number = Prompt("Введите число: ");
System.Console.WriteLine(digitsSum(Math.Abs(number)));