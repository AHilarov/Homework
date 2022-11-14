// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int exponentation (int a, int b)
{
    int count = 0;
    int result = a;
    while (count < b-1)
    {
        result = result * a;
        count++;
    }
    return result;
}


int digit = PromptInt("Введите число: ");
int degree = PromptInt("Введите в какую степень возвести: ");
int answer = exponentation(digit, degree);
System.Console.WriteLine($"{digit} ^ {degree} = {answer}");