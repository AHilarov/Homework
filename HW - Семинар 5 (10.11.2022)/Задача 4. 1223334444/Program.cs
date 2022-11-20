// Задача 4 (*) При помощи рекурсии вывести последовательность чисел, с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
Prompt("Сколько раз повторить?");
System.Console.WriteLine(Prompt);

// for (int i = 0; i < Prompt; i++)
// {
//     System.Console.WriteLine(Prompt);
// }
