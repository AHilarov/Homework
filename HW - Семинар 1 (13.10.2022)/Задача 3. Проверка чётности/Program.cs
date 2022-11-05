// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Эта программка будет проверять является ли введенное числo чётным. (Пожалуста, вводите только целые числа).");
Restart:            //ссылка на откуда повторять
    Console.Write("Введите число: ");
string? input = Console.ReadLine();
int number = Convert.ToInt32(input);
if (number % 2 == 0)
{
Console.WriteLine("Чётное");
}
else {Console.WriteLine("Нечетное");}


// блок повтора
Console.Write("Повторить? [Y/N] ");
string? Answer = Console.ReadLine();
if (Answer.ToLower() == "y") 
{
    goto Restart;
}
else Console.WriteLine("Пока!");

