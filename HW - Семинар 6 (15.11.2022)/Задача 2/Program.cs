// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = a1 * x + b1
// y = a2 * x + b2
// a1 * x + b1 = a2 * x + b2
// a1*x - a2*x = b2 - b1
// x(a1 - a2) = b2 - b1
// x = (b2 - b1) / (a1 - a2)

const int a1 = 0;
const int b1 = 1;
const int a2 = 2;
const int b2 = 3;

double Prompt(string strMessage) //ввод числа после сообщения
{
    System.Console.Write(strMessage);
    double temp = double.Parse(System.Console.ReadLine());
    return temp;
}

void FillArray(double[] collection) //заполнение массива заданной длины
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght) // до тех пор пока индекс меньше длины
    {
        double digit = Prompt($"Введите {index + 1} коэффициент: ");
        collection[index] = digit;
        index++;
    }
}

double FindX(double[] array)
{
    double x = (array[b2] - array[b1]) / (array[a1] - array[a2]);
    return x;
}

void Execute()
{
    double[] array = new double[4];
    Console.WriteLine(
        "Для двух уравнений типа y = ax + b, введите коэффициенты в следующей последовательности — a1, b1, a2, b2"
    );
    FillArray(array); 
    if (array[a1] != array[a2])
    {
        double x = FindX(array);
        double y = array[a1] * x + array[b1];
        Console.WriteLine("Для двух прямых, описываемых уравнениями");
        Console.WriteLine($"y = {array[a1]}*x + {array[b1]} и ");
        Console.WriteLine($"y = {array[a2]}*x + {array[b2]}");
        Console.WriteLine($"точка пересечения имеет координаты x = {x} и y = {y}");
    }
    else
    {
        Console.WriteLine("Прямые параллельны и не пересекаются");   
    }
}
Execute();