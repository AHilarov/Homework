// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message) // это универсальный метод выведения сообщения и приём числа от пользователя в переменную number
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number) // это метод проверки числа
{
    if (number > 99999 || number < 10000)
    {
        Console.WriteLine("Вы ввели неправильное число. Попробуйте ещё раз.");
        return false;           
    }
    return true;
}

//bool ValidateEqual(int numberFirst, int numberLast) // это метод проверки числа
// {
//     if (numberFirst != numberLast)
//     {
//         Console.WriteLine("Не палиндром.");
//         return false;           
//     }
//     return true;
// }

int number = Prompt ("Введите пятизнаное число: ");

void FillArray(int[] collection) // заполнение массива
{
    int lenght = collection.Length;
    int index = 0;
    int razryad = 4;
    while (index < lenght) // до тех пор пока индекс меньше длины
    {
        //int number = Prompt("Введите число: ");
        collection[index] = number /(10*razryad);
        //sum = sum + number;
        index++;
        razryad = razryad-1;
    }
}

void PrintArray(int[] col) // ЭТО метод выводящий на печать 
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}





PrintArray(array);
// if (ValidateNumber(number))
// {
//     //int LastDigit = number %10;

//     //Console.WriteLine(number);
// }