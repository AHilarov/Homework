// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int Prompt(string strMessage) //ввод числа после сообщения
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

void FillArray(int[] collection) //заполнение массива заданной длины
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght) // до тех пор пока индекс меньше длины
    {
        int digit = Prompt($"Введите {index+1} число: ");
        collection[index] = digit;
        index++;
    }
}

int CountPositive(int[] array, bool isPositive = true)  //сумма положительных в массиве
{
    int invertor = 1;
    if (!isPositive){
        invertor *= -1;
    }
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] * invertor) > 0)
        {
            count++;
        }
    }
    return count;
}

int length = Prompt("Укажите длину массива: ");

int[] array = new int[length];
FillArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Вы ввели {CountPositive(array)} положительных чисел");