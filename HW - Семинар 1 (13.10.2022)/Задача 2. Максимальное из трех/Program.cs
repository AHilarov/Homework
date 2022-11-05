// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Эта программка будет выдавать максимальное число из трех. (В дробях целая часть от дробной отделяется запятой).");
Restart:            //ссылка на откуда повторять
    Console.Write("Введите первое число: ");
String? input1 = Console.ReadLine ();
double numberA = Convert.ToDouble (input1);
Console.Write("Введите второе число: ");
String? input2 = Console.ReadLine ();
double numberB = Convert.ToDouble (input2);
Console.Write("Введите третье число: ");
String? input3 = Console.ReadLine ();
double numberC = Convert.ToDouble (input3);

double max = numberA;

if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
Console.WriteLine($"Из введенных вами чисел максимальным явялется {max}");

// Блок повтора
Console.WriteLine("Повторить? [Y/N]");
string? Answer = Console.ReadLine();
if (Answer.ToLower() == "y") 
{
    goto Restart;
}
else Console.WriteLine("Пока!");

