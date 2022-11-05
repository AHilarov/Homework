// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Эта программка будет сравнивать два числа. (В дробях целая часть от дробной отделяется запятой).");
Restart:            //ссылка на откуда повторять
    Console.Write("Введите первое число: ");
String? input1 = Console.ReadLine ();
double numberA = Convert.ToDouble (input1);
Console.Write("Введите второе число: ");
String? input2 = Console.ReadLine ();
double numberB = Convert.ToDouble (input2);

if (numberA > numberB) Console.WriteLine ($"Число {numberA} больше, чем число {numberB}");
if (numberB > numberA) Console.WriteLine ($"Число {numberB} больше, чем число {numberA}");
if (numberA == numberB) Console.WriteLine ($"Число {numberA} равно числу {numberB}");

// Блок повтора
Console.WriteLine("Повторить? [Y/N]");
string? Answer = Console.ReadLine();
if (Answer.ToLower() == "y") 
{
    goto Restart;
}
else Console.WriteLine("Пока!");