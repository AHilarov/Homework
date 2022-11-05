// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Эта программка будет на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");
Restart:            //ссылка на откуда повторять
Console.Write("Введите целое положительное число больше 1: ");
string? input = Console.ReadLine();
int number = Convert.ToInt32(input);
int result = 2;
//int count = 0;
if (number > 1)
{
    while (result -2 < number - 3)
// result - он же счётчик, но поскольку result начинается с 2, считать начинаем с result-2, то есть с 0
// number делаем минус 3 (1+2). минус 1, чтобы если введенное число нечёт, то счётчик, чтобы не перескакивал, а минус 2 чтобы не висело в конце запятой. Мы его потом езё раз выведем
    {
    Console.Write($"{result}, ");
    result = result + 2;
    //count = count + 2;
    }
Console.WriteLine(result);
}
else Console.WriteLine("Вы ввели неправильное число");



// блок повтора
Console.Write("Повторить? [Y/N] ");
string? Answer = Console.ReadLine();
if (Answer.ToLower() == "y")
{
    goto Restart;
}
else Console.WriteLine("Пока!");