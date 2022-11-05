//Перезапуск проаграммы
Restart:
    Console.WriteLine("Повторить? [Y/N]");
string? Answer = Console.ReadLine();
if (Answer.ToLower() == "y") 
{
    goto Restart;
}
else Console.WriteLine("Пока!");
