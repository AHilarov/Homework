//Перезапуск проаграммы
Restart:
Console.Write("Повторить? [Y/N] ");
string? Answer = Console.ReadLine();
if (Answer.ToLower() == "y")
{
    goto Restart;
}
else Console.WriteLine("Пока!");